using System;
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
        public int ttl = 50;
        public int timeout = 1000;
        public void StatusUpdate(int TtL, int TimeOut)
        {
            ttl = TtL;
            timeout = TimeOut;
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

            if (PingIP && PingPortal == false)
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
            if (PingIP == false && PingPortal)
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
            if (PingPortal && PingIP)
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
            if (!IgnoreIP)
            {
                if (!IsValidIP(IP))
                {
                    MessageBox.Show("IP is Invalid");
                    IP = "X.X";
                }
            }
            if (IgnoreIP && IgnorePortal)
            {
                StatusIconIndex = 0;
                Status = "Undetermined";
            }
            if (!PortalLink.Contains("http://") && !PortalLink.Contains("https://"))
            {
                PortalLink = "http://" + PortalLink;
            }
            GetAddressFromLink(PortalLink);
            if (IgnorePortal)
            {
                Portal = "None.Set";
                PortalLink = "None";
            }
            if (IgnoreIP)
            {
                IP = "None.Set";
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
        public bool IsValidIP(string ip)
        {
            if (String.IsNullOrEmpty(ip))
            {
                return false;
            }

            // Split the IP address into its octets
            string[] octets = ip.Split('.');

            // Check if there are exactly 4 octets
            if (octets.Length != 4)
            {
                return false;
            }

            // Check if each octet is a valid integer between 0 and 255
            for (int i = 0; i < octets.Length; i++)
            {
                int octet;
                if (!int.TryParse(octets[i], out octet) || octet < 0 || octet > 255)
                {
                    return false;
                }
            }

            return true;
        }
        public bool PingHost(string nameOrAddress)
        {
            bool pingable = false;

            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingOptions options = new PingOptions(ttl, true);
                PingReply reply = pinger.Send(nameOrAddress, timeout, new byte[32], options);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("TTL or Timeout are out of range!\n" +
                    "PLease Check Settings");
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
