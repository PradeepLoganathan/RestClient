using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace RestClient
{
    public class RestRequest
    {
        private List<KeyValuePair<string, string>> _URLSegment;
        private List<KeyValuePair<string, string>> _QueryString;
        public object Body { get; set; }

        public void AddQueryString(string Key, string Value)
        {

        }

        public void AddURLSegment(string Key, string Value)
        {

        }

        public void SetBody(object obj)
        {

        }

        public async Task<RestResponse> ExecuteDelete()
        {

        }

        public async Task<RestResponse> ExecuteGet()
        {

        }


        public async Task<RestResponse> ExecutePost()
        {

        }

    }
}
