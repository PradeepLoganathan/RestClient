using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace RestClient
{
    public class RestResponse
    {

        private HttpResponseMessage response;


        public Uri BaseURI { get; set; }
        public Encoding Encoding { get; set; } = new UTF8Encoding(false);

        public HttpStatusCode StatusCode 
        {
            get
            {
                return response.StatusCode;
            }
        }
                

        public RestResponse()
        {
            response = new HttpResponseMessage();
        }

        public async Task<IEnumerabe<string>> GetHeader(string HeaderName)
        {
            return await response.Headers.GetValues(HeaderName).FirstOrDefault();
        }
        public async Task<String> GetContent()
        {

        }

    }

    public class RestResponse<T> : RestResponse
    {

    }
}
