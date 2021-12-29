using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenetApiClient.Models {
    public class RequestResult<T> {
        public bool key_valid { get; set; }
        public bool key_enabled { get; set; }
        public string acao { get; set; }
        public string status { get; set; }
        public T results { get; set; }
    }
}
