

using DEV.JsonObjects;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV
{
    public partial class Pagamento : System.Web.UI.Page
    {
        private void preecherDados(PagamentoRede _pagamento)
        {
            _pagamento.capture = "false";
            _pagamento.kind = "credit";
            _pagamento.reference = "0133";
            _pagamento.amount = "2049";
            _pagamento.installments = "12";
            _pagamento.cardholderName = "Marcos Rocha";
            _pagamento.cardNumber = "5448280000000007";
            _pagamento.expirationMonth = "1";
            _pagamento.expirationYear = "2028";
            _pagamento.securityCode = "123";
            _pagamento.subscription = false;
            _pagamento.origin = "1";
            _pagamento.distributorAffiliation = "0";
            _pagamento.brandTid = "VISA";
            _pagamento.storageCard = "1";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            string urlBase = @"https://sandbox-erede.useredecloud.com.br";
            string UrlBaseConsulta = @"";

            PagamentoRede _pagamento = new PagamentoRede();
            preecherDados(_pagamento);

            string jsonCompra = Newtonsoft.Json.JsonConvert.SerializeObject(_pagamento);
            string PV = "98812960";
            string TOKEN = "036eeb70e7754b0fa687e3853e916e6f";

            var client = new RestClient(urlBase + "/v1/transactions");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("MerchantId", PV);
            request.AddHeader("MerchantKey", TOKEN);
   
            request.AddParameter("application/json", jsonCompra, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Newtonsoft.Json.JsonConvert.DeserializeObject<PagamentoRede>(response.Content);
        }
    }
}