using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WebClientData
    {
        string Name;
        int Id;
        string IP;
        bool SSL;

        public WebClientData(string name, int id, string ip, bool ssl)
        {
            this.Name = name;
            this.Id = id;
            this.IP = ip;
            this.SSL = ssl;
        }

        public ClientData getClientData()
        {
            return new ClientData(Name, Id);
        }

        public override string ToString()
        {
            return $"client name: {Name}, ID: {Id}, IP: {IP}, ssl: {SSL}";
        }
    }
}
