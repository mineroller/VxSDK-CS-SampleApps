using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace VxDataSourceViewer
{
    class Common
    {
        // HTTPS 메시지 송수신
        // VideoXpert 는 TLS/443 보안통신만을 사용합니다

        public async Task<HttpResponseMessage> SendRequest(Uri uri, string _username, string _password)
        {
            HttpResponseMessage response = null;
            // Create a new WebClient instance.
            using (var client = new HttpClient())
            {
                // Supply the username and password that was used to create the VideoXpert system.
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                request.Headers.Add("X-Serenity-User", EncodeToBase64(_username));
                request.Headers.Add("X-Serenity-Password", EncodeToBase64(_password));

                if (ServicePointManager.SecurityProtocol != (SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3))
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;

                // Forces the WebClient to trust the security certificate handed back from the VideoXpert server.
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                response = await client.SendAsync(request);
            }
            return response;
        }

        // HTTP Request 전송시 사용자이름및 암호를 Base64로 인코딩하여 전송합니다

        private static string EncodeToBase64(string toEncode)
        {
            var toEncodeAsBytes = Encoding.ASCII.GetBytes(toEncode);
            var returnValue = Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }

    }
}
