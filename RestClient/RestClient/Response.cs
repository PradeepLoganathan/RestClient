using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient
{
    class Response
    {

        private int MaxRetryCount;

        public Uri BaseURI { get; set; }
        public Encoding Encoding { get; set; } = new UTF8Encoding(false);

    }
}
