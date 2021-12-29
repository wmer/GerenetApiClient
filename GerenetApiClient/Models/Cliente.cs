using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenetApiClient.Models {
    public class Cliente {
        public string id { get; set; }
        public string nome { get; set; }
        public string fantasia { get; set; }
        public string pessoa { get; set; }
        public string cpfcnpj { get; set; }
        public string rg { get; set; }
        public string inscricao_estadual { get; set; }
        public string inscricao_municipal { get; set; }
        public string classe_fiscal { get; set; }
        public string sexo { get; set; }
        public string data_nascimento { get; set; }
        public string email { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string telefone3 { get; set; }
        public string telefone4 { get; set; }
        public string telefone5 { get; set; }
        public string telefone6 { get; set; }
        public string representante { get; set; }
        public string representantecargo { get; set; }
        public string representantecpf { get; set; }
        public string representanterg { get; set; }
        public string servicos_base { get; set; }
        public string senha_central { get; set; }
        public string acrescimo { get; set; }
        public string desconto { get; set; }
        public string data_cadastro { get; set; }
        public string data_bloqueio { get; set; }
        public string data_desativacao { get; set; }
        public int id_status { get; set; }
        public string situacao { get; set; }
        public string status { get; set; }
        public List<Endereco> enderecos { get; set; }
    }
}
