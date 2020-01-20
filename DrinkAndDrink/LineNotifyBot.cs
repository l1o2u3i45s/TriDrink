using DrinkAndDrink.LineNotifyWeb;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DrinkAndDrink
{
    public static class LineNotifyBot
    {
        private static string token = "85ZiMaaVLQ9nIcbP5bzQ8C1NEyTyiuq3TKh9ZkcWkEF";
        public static void SendMessage(string message)
        {
            string url = "https://notify-api.line.me/api/notify";
            string postData = "message=" + WebUtility.HtmlEncode("\r\n" + message);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            Uri target = new Uri(url);
            WebRequest request = WebRequest.Create(target);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            request.Headers.Add("Authorization", "Bearer " + token);

            using (var dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
        }
        public static async Task GetUserCode()
        {
            string url = @"https://notify-bot.line.me/oauth/authorize?
                response_type=code
                &scope=notify
                &client_id=	0t0WbPzcpYkAh8Zkvuv5St
                &redirect_uri=https://github.com/l1o2u3i45s/TriDrink";

            //LineNotifyWebWindow web = new LineNotifyWebWindow();
            //web.ChromiumWebBrowser.Address = url;
           await GetAccessTokenAsync("DSC3uZOhiPyAaq1e3PRTnc");
            
        }
        public static async Task GetAccessTokenAsync(string code)
        {
            string url = @"https://notify-bot.line.me/oauth/token";
           
            var formContent = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("grant_type", "authorization_code"),
            new KeyValuePair<string, string>("code",code),
            new KeyValuePair<string, string>("redirect_uri", "https://github.com/l1o2u3i45s/TriDrink"),
            new KeyValuePair<string, string>("client_id", "0t0WbPzcpYkAh8Zkvuv5St"),
            new KeyValuePair<string, string>("client_secret", "jD6vMAgkHJ2scusFs2cJ94A4fPX6HHljAtkviEpaCGe")
            });

            var myHttpClient = new HttpClient();
            var response = await myHttpClient.PostAsync(url, formContent);
            var stringContent = await response.Content.ReadAsStringAsync();
        }

    }
    
}
