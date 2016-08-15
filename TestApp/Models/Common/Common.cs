using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace TestApp.Models.Common
{
    public class Common
    {
        public async Task<string> SendGetRequestAsync(string moneda)
        {

            var builder = new UriBuilder(@"http://www.bancoprovincia.com.ar/");

            HttpResponseMessage httpResponse;
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = builder.Uri;
                httpResponse = await httpClient.GetAsync(string.Format("Principal/{0}", moneda));
                httpResponse.EnsureSuccessStatusCode();
            }
            if ((int)httpResponse.StatusCode != 200) return null;

            return await httpResponse.Content.ReadAsStringAsync();
        }
    }
}