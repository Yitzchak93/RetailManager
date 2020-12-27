using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RMDesktopUI.Helpers
{
    public class APIHelper
    {
        public HttpClient ApiClient { get; set; }
        public APIHelper()
        {

        }
        private void InitializeClient()
        {
            string api = ConfigurationManager.AppSettings["api"];


            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("grant_type", "password"),
            new KeyValuePair<string, string>("password", password),
            new KeyValuePair<string, string>("username",username)
            });

            using (HttpResponseMessage response = await ApiClient.PostAsync("/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<string>();
                }
            }
        }

    }
}
