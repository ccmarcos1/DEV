using DEV.WEB.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV.WEB
{
    public partial class pagamentoForm : System.Web.UI.Page
    {

        private int getIdProduto()
        {
            int idProduto = -1;
            if (Request["idProduto"] != null)
            {
                //se for diferente de nulo tenta converte ele para um valor inteiro se conseguir converte - alimenta a variavel.
                int.TryParse(Request["idProduto"].ToString(), out idProduto);
            }
            return idProduto;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Formas de Pagamento


            if (!Page.IsPostBack)
            {

                if (Request["idProduto"] != null)
                {
                    formapagamento();
                    parcelas();
                    carregarDadosProduto();

                }

            }
            

        }
        private void formapagamento()
        {
            ddlFormaPagamento.Items.Add(new ListItem("CREDITO", "credit"));
            ddlFormaPagamento.Items.Add(new ListItem("DEBITO", "debit"));
        }
        protected void ddlFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            parcelas();

        }
        private void parcelas()
        {
            if (ddlFormaPagamento.SelectedValue == "credit")
            {
                ddlParcelas.Items.Clear();
                ddlParcelas.Items.Add(new ListItem("A Vista", "1"));
                ddlParcelas.Items.Add(new ListItem("2x", "2"));
                ddlParcelas.Items.Add(new ListItem("3x", "3"));
                ddlParcelas.Items.Add(new ListItem("4x", "4"));
                ddlParcelas.Items.Add(new ListItem("5x", "5"));
                ddlParcelas.Items.Add(new ListItem("6x", "6"));
                ddlParcelas.Items.Add(new ListItem("7x", "7"));
                ddlParcelas.Items.Add(new ListItem("8x", "8"));
                ddlParcelas.Items.Add(new ListItem("9x", "9"));
                ddlParcelas.Items.Add(new ListItem("10x", "10"));
                ddlParcelas.Items.Add(new ListItem("11x", "11"));
                ddlParcelas.Items.Add(new ListItem("12x", "12"));
            }
            else if (ddlFormaPagamento.SelectedValue == "debit")
            {

                ddlParcelas.Items.Clear();
                ddlParcelas.Items.Add(new ListItem("A Vista", "0"));
            }

        }
        protected void ddlQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var produto = obterProduto();
            var valortotal =  int.Parse(ddlQuantidade.SelectedValue);
            lvalortotal.Text = valortotal.ToString();

        }
        protected ProdutoService.PRODUTO obterProduto()
        {

            int idProduto = -1;
            if (Request["idProduto"] != null)
            {
                //se for diferente de nulo tenta converte ele para um valor inteiro se conseguir converte - alimenta a variavel.
                int.TryParse(Request["idProduto"].ToString(), out idProduto);
            }

            ProdutoService.ProdutoServiceClient service = new ProdutoService.ProdutoServiceClient();
            ProdutoService.PRODUTO produto = service.obterProduto(idProduto);
            return produto;
        }

        protected void carregarDadosProduto()
        {

            // Request para pega o idProduto da URL.
            var produto = obterProduto();
            if (produto != null)
            {
                lProduto.Text = produto.NOME;
                //txtValor.Text = produto.VALOR.ToString();
                //txtQuantidade.Text = produto.QUANTIDADE.ToString();
                for (int i = 1; i <= produto.QUANTIDADE; i++)
                {
                    var valor = produto.VALOR * i;
                    ddlQuantidade.Items.Add(new ListItem(i.ToString(), valor.ToString()));
                }


                lvalortotal.Text = produto.VALOR.ToString();
            }
            else
            {
                Response.Write("Produto Nao encontrado.");
            }

        }
        public string retornarCodigoReferenciaNovo(string letraAuxiliar)
        {
            Random rd = new Random();
            string codigo = rd.Next(0, 999999).ToString("000000");
            if (!string.IsNullOrEmpty(letraAuxiliar))
            {
                codigo = letraAuxiliar + codigo;
            }

            if (verificarCodUnicoReferencia(codigo))
            {
                return retornarCodigoReferenciaNovo(letraAuxiliar);
            }
            else
            {
                return codigo;
            }
        }
        public bool verificarCodUnicoReferencia(string codigo)
        {
            PagamentoService.PagamentoServiceClient service = new PagamentoService.PagamentoServiceClient();

            PagamentoService.REGISTROVENDA pagamento = service.obterCodigoReferencia(codigo);
    
            if(pagamento == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        // Cartao CREDITO TESTE - 5448280000000007 - MASTARCARD
        //Cartao DEBITO TESTE - 5277696455399733  - MASTARCARD

        private PagamentoRede Pagamento(PagamentoRede _pagamento)
        {
            
            _pagamento.reference = retornarCodigoReferenciaNovo(null);
            //_pagamento.capture = true;
            _pagamento.kind = ddlFormaPagamento.SelectedValue;
            _pagamento.amount = lvalortotal.Text.ToString();
            _pagamento.installments = Int32.Parse(ddlParcelas.SelectedValue);
            //Dados do Cartao
            _pagamento.cardholderName = txtNome.Text;
            _pagamento.cardNumber = txtCardNumber.Text;
             string Datavencimento = txtVencimento.Text; // 06/22
            _pagamento.expirationMonth = Datavencimento.Remove(Datavencimento.Length - 3); //-> 06
            _pagamento.expirationYear = Datavencimento.Substring(Datavencimento.Length - 2); //-> 22
            _pagamento.securityCode = txtCVV.Text;
            _pagamento.softDescriptor = lProduto.Text;
            //_pagamento.subscription = false;
            //_pagamento.origin = "1";
            _pagamento.distributorAffiliation = "98812960";
            //_pagamento.brandTid = "string";
            //_pagamento.storageCard = "1";

            return _pagamento;
        }
            protected void btSalvar_Click(object sender, EventArgs e)
        {
            var _pagamento = new PagamentoRede();
            Pagamento(_pagamento);

            string jsonCompra = Newtonsoft.Json.JsonConvert.SerializeObject(_pagamento);

           
            var urlBase = @"https://sandbox-erede.useredecloud.com.br";
            var urlBaseConsulta = @"";

            var client = new RestClient(urlBase+"/v1/transactions");
            client.Timeout = -1;
          
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic OTg4MTI5NjA6MDM2ZWViNzBlNzc1NGIwZmE2ODdlMzg1M2U5MTZlNmY=");
            request.AddHeader("Content-Type", "application/json");
            
            request.AddParameter("application/json", jsonCompra, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            dynamic _resultPayment = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);
            dynamic _resultComprar = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonCompra);

            //Se sucesso ao receber Salvar dados da venda.
            if (_resultPayment.returnCode.ToString() == "00") {
                PagamentoService.PagamentoServiceClient service = new PagamentoService.PagamentoServiceClient();
                int idProduto = getIdProduto();
                service.salvarRegistroPagamento(_resultPayment.reference.ToString(), idProduto.ToString(), ddlFormaPagamento.SelectedValue, ddlQuantidade.SelectedItem.ToString(), lvalortotal.Text);

                service.salvarRegistroFormaPagamento(_resultPayment.reference.ToString(), _resultPayment.amount.ToString(), _resultComprar.installments.ToString(), 
                    _resultComprar.kind.ToString(), _resultPayment.returnCode.ToString(), _resultPayment.returnMessage.ToString(), _resultPayment.tid.ToString(),
                    _resultPayment.nsu.ToString(), _resultPayment.cardBin.ToString(), _resultPayment.authorizationCode.ToString(), _resultComprar.ToString(), _resultPayment.ToString());
                Response.Redirect("/detalheDeRecebimento.aspx?idReferencia=" + _resultPayment.reference.ToString() + "&idProduto=" + idProduto.ToString());
            }
            else {
                
             }
        }
        protected void btCancelar_Click(object sender, EventArgs e)
        {

            Response.Redirect("/recebimentoVendas.aspx");
        }
      
    }

}