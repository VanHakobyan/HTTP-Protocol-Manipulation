using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HTTPProtocolAnalyzer
{
    public class LinkWriter : IDisposable
    {
        private StreamWriter sw;
        private WebClient wc = new WebClient();
        public LinkWriter(string path)
        {
            sw = new StreamWriter(path);
        }
        public void linkSaver(string link)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }

            Uri uri = new Uri(link);
          
            var html = wc.DownloadString(uri);
   
            sw.Write(html);
        }






        public void Dispose()
        {
            sw.Dispose();
            wc.Dispose();
        }
    }
}
