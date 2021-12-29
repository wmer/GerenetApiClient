using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenetApiClient.Models {
    public class ClienteBasico {
        public int id { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public List<Estado> estado { get; set; }
    }
}
