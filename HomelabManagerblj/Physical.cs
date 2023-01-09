﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomelabManagerblj
{
    public class Physical
    {
        public string IP { get;  set; }
        public string Portal { get;  set; }
        public string PortalLink { get; set; }
        public string Name { get;  set; }
        public bool IgnoreIP { get; set; }
        public bool IgnorePortal { get; set; }
        public string Status { get;  set; }
        public int StatusIconIndex = 0;
        
        public void StatusUpdate()
        {
            bool PingIP = false;
            bool PingPortal = false;
            bool IPSuccess = false;
            bool PortalSuccess = false;
            SelfRepair();
            if (!IgnoreIP)
            {
                PingIP = true;
            }
            if (!IgnorePortal)
            {
                PingPortal = true;
            }
            if (PingIP)
            {
                if (PingHost(IP))
                {
                    IPSuccess = true;
                }
            }
            if (PingPortal)
            {
                if (PingHost(Portal))
                {
                    PortalSuccess = true;
                }
            }
            
            if(PingIP && PingPortal == false)
            {
                if (IPSuccess)
                {
                    Status = "Running";
                    StatusIconIndex = 1;
                }
                if (IPSuccess == false)
                {
                    Status = "DOWN";
                    StatusIconIndex = 3;
                }
            }
            if(PingIP == false && PingPortal)
            {
                if (PortalSuccess)
                {
                    Status = "Running";
                    StatusIconIndex = 1;
                }
                if (PortalSuccess == false)
                {
                    Status = "DOWN";
                    StatusIconIndex = 3;
                }
            }
            if(PingPortal && PingIP)
            {
                if (PortalSuccess || IPSuccess)
                {
                    Status = "Partialy Running";
                    StatusIconIndex = 2;
                }
                if (IPSuccess && PortalSuccess)
                {
                    Status = "Running";
                    StatusIconIndex = 1;
                }
                if (IPSuccess == false && PortalSuccess == false)
                {
                    Status = "DOWN";
                    StatusIconIndex = 3;
                }
            }
        }
        public void SelfRepair()
        {
            if (!PortalLink.Contains("http://") && !PortalLink.Contains("https://"))
            {
                PortalLink = "http://" + PortalLink;
            }
            GetAddressFromLink(PortalLink);
            if (IgnorePortal)
            {
                Portal = "None";
                PortalLink = "None";
            }
            if (IgnoreIP)
            {
                IP = "None";
            }
        }
        public void GetAddressFromLink(string portalLink)
        {
            Match match = Regex.Match(portalLink, @"(?:[\d]{1,3})\.(?:[\d]{1,3})\.(?:[\d]{1,3})\.(?:[\d]{1,3})|(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\.)+[a-zA-Z]{2,}");

            if (match.Success)
            {
                Portal = match.Value;
            }
        }
        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;

            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingOptions options = new PingOptions(50, true);
                PingReply reply = pinger.Send(nameOrAddress, 1000, new byte[32], options);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Abort on the first failed ping attempt

            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
