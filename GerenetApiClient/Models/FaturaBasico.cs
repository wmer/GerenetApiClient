using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenetApiClient.Models {
    public class FaturaBasico {
        public string id { get; set; }
        public bool pago { get; set; }
        public int situacao { get; set; }
    }
}
