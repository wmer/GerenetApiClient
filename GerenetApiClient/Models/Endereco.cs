using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenetApiClient.Models {
    public class Endereco {
        public string tipo { get; set; }
        public string apto { get; set; }
        public string andar { get; set; }
        public string bloco { get; set; }
        public string quadra { get; set; }
        public string lote { get; set; }
        public string casa { get; set; }
        public string ponto_ref { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string id_cidade { get; set; }
        public string cidade { get; set; }
        public string cidade_identificacao { get; set; }
        public string cidade_codigo_ibge { get; set; }
        public string uf { get; set; }
    }
}
