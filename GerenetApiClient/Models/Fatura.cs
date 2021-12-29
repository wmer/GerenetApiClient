using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenetApiClient.Models {
    public class Fatura {
        public string clienteId { get; set; }
        public string titulo { get; set; }
        public int tipo_boleto { get; set; }
        public string vencimento { get; set; }
        public string valor { get; set; }
        public string linha_digitavel { get; set; }
        public string link { get; set; }
        public string vecto { get; set; }
    }
}
