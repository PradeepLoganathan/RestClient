using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;

namespace RestClient
{
    public class RestResponse
    {

        protected HttpResponseMessage Response;


        public Uri BaseURI { get; set; }
        public Encoding Encoding { get; set; } = new UTF8Encoding(false);

        public HttpStatusCode StatusCode 
        {
            get
            {
                return Response.StatusCode;
            }
        }
                

        public RestResponse(HttpResponseMessage response)
        {
            Response = response;
        }

        /// <summary>
        /// This method retrieves the header specified by HeaderName from the response.
        /// </summary>
        /// <param name="HeaderName">Header Name to retrieve from the Response</param>
        /// <returns></returns>
        public IEnumerable<string> GetHeader(string HeaderName)
        {
            return Response.Headers.GetValues(HeaderName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetContent()
        {
            return await Response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

    }

    public class RestResponse<T> : RestResponse
    {

        public RestResponse(HttpResponseMessage response) : base(response)
        {

        }
            
        public async Task<T> GetDataObject()
        {
            Stream content = await Response.Content.ReadAsStreamAsync().ConfigureAwait(false);

            using (StreamReader sr = new StreamReader(content, Encoding.UTF8))
            using (JsonTextReader Jt = new JsonTextReader(sr))
                return JsonSerializer.CreateDefault().Deserialize<T>(Jt);
        }

    }
}
