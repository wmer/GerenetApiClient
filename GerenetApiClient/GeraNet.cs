using GerenetApiClient.Models;
using ManyHelpers.API;
using ManyHelpers.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenetApiClient {
    public class GeraNet {
        private CosumingHelper _api;

        public GeraNet(string baseAdress) {
            _api = new CosumingHelper(baseAdress)
                                .AddcontentType();
        }

        public async Task<List<ClienteBasico>> GetInfoBasicaClientes(string key, string estadoCliente = null) {
            var result = await _api.GetAssync<RequestResult<List<ClienteBasico>>>($"ws_sap_json.php?chave={key}&acao=ObterClientes&estadoCliente={estadoCliente}");
            return result.result?.results;
        }

        public async Task<List<Cliente>> GetCliente(string key, int id) {
            var result = await _api.GetAssync<RequestResult<List<Cliente>>>($"ws_sap_json.php?chave={key}&acao=ObterClienteId&id_assinante={id}");
            return result.result?.results;
        }

        public async Task<SituacaoCliente> GetSituacaoCliente(string key, int id) {
            var result = await _api.GetAssync<RequestResult<SituacaoCliente>>($"ws_ura_json.php?chave={key}&acao=consulta_situacao_assinante&id_assinante={id}");
            return result.result?.results;
        }

        public async Task<List<FaturaBasico>> GetFaturas(string key, int status = 0, int situacao = 0) {
            var result = await _api.GetAssync<RequestResult<List<FaturaBasico>>>($"ws_sap_json.php?chave={key}&acao=ObterDocReceber&status={status}&situacaoFatura={situacao}");
            return result.result?.results;
        }

        public async Task<List<FaturaBasico>> GetDetalhesFaturasByid(string key, string idFatura = null) {
            var result = await _api.GetAssync<RequestResult<List<FaturaBasico>>>($"ws_sap_json.php?chave={key}&acao=ObterDocReceberId&idFatura={idFatura}");
            return result.result?.results;
        }

        public async Task<List<Fatura>> GetDetalhesFaturas(string key, string cpfCnpj = null) {
            var result = await _api.GetAssync<RequestResult<List<Fatura>>>($"ws_ura_json.php?chave={key}&acao=lista_tit_pend&cpf_cnpj={StringHelper.GetOnlyPositiveNumbers(cpfCnpj)}");
            return result.result?.results;
        }

        public async Task<List<Fatura>> GetFaturasEmAberto(string key, string cpfCnpj = null) {
            var result = await _api.GetAssync<RequestResult<List<Fatura>>>($"ws_ura_json.php?chave={key}&acao=boletos_em_aberto&cpf_cnpj={StringHelper.GetOnlyPositiveNumbers(cpfCnpj)}");
            return result.result?.results;
        }
    }
}
