using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace longdbSpeakTxt.Tools
{
    public class HttpUtil
    {
        private static HttpUtil httpUtil = null;
        private HttpUtil()
        {
        }
        public static HttpUtil GetSingleton()
        {
            if (httpUtil == null)
            {
                httpUtil = new HttpUtil();
                return httpUtil;
            }
            else
            {
                return httpUtil;
            }
        }
        public Stream ReadImgFromWeb(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Credentials = CredentialCache.DefaultCredentials; // 添加授权证书
            request.UserAgent = "Microsoft Internet Explorer";
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            return stream;
        }
    }
}
