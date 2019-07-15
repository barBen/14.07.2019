using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_v2
{
    public class WebInfo : IProtoType<WebInfo>
    {
        protected DateTime timeStamp;
        protected string size;
        protected string url;

        public WebInfo(DateTime timeStamp, string size, string url)
        {
            this.timeStamp = timeStamp;
            this.size = size;
            this.url = url;
        }

        public override string ToString()
        {
            return $"webInfo time: {this.timeStamp},         size: {this.size},         url: {this.url}";
        }

        public WebInfo clone()
        {
            return new WebInfo(timeStamp, size, url);
        }
    }
}
