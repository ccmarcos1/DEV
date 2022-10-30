using DEV.WEB.Models;
using DEV.WEB.PagamentoService;
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
    public partial class detalheDeRecebimento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                if (Request["idReferencia"] != null && Request["idProduto"] != null)
                {
                   
                    PreencherDadosVenda();

                }
                else
                {
                    Console.Write("Venda Nao encontrada");
                }
            }
        }
        protected void PreencherDadosVenda()
        {
            PagamentoService.PagamentoServiceClient service = new PagamentoService.PagamentoServiceClient();
            var Pagamentos = service.listarPagamentos();
            rptUsuarios.DataSource = Pagamentos.Where(s => s.CODIGOREFERENCIA == Request["idReferencia"].ToString());
            rptUsuarios.DataBind();
            var _dataCancelamento = Pagamentos.Where(n => n.CODIGOREFERENCIA == Request["idReferencia"].ToString()).ToList();

            var data = _dataCancelamento[0].DATACANCELAMENTO.ToString();
            if (data != "01/01/2000 00:00:00")
            {
                btExclui.Visible = false;
            }
            else
            {
                btExclui.Visible = true;
            }
            ProdutoService.ProdutoServiceClient produtoService = new ProdutoService.ProdutoServiceClient();
            var produtos = produtoService.listarProdutos();
            rptProdutos.DataSource = produtos.Where(s => s.ID == int.Parse(Request["idProduto"]));
            rptProdutos.DataBind();

            var Fromapagamento = service.listarFormaPagamento();
            rptFormaPagamento.DataSource = Fromapagamento.Where(s => s.CODIGOREFERENCIA == Request["idReferencia"].ToString());
            rptFormaPagamento.DataBind();
            //btExclui.Text = "Excluir";
            ltitulo.Text = "Detalhe de Recebimento - Referencia: " + Request["idReferencia"];
        }
        //protected PagamentoService.REGISTROVENDA obterVenda()
        //{

        //    string idReferencia = "";
        //    if (Request["idReferencia"] != null)
        //    {
        //        //se for diferente de nulo tenta converte ele para um valor inteiro se conseguir converte - alimenta a variavel.
        //        idReferencia = Request["idReferencia"].ToString();
        //    }

        //    PagamentoService.PagamentoServiceClient service = new PagamentoService.PagamentoServiceClient();
        //    PagamentoService.REGISTROVENDA registroVenda = service.obterPagamento(idReferencia);
        //    return registroVenda;
        //}
        //protected void carregarDadosVenda()
        //{

        //    // Request para pega o idProduto da URL.
        //    var registroVenda = obterVenda();
        //    if (registroVenda != null)
        //    {
        //        //txtNome.Text = registroVenda.IDPRODUTO.ToString();
        //        //txtValor.Text = registroVenda.VALOR.ToString();
        //        //txtQuantidade.Text = registroVenda.QUANTIDADE.ToString();
        //    }
        //    else
        //    {
        //        Response.Write("Produto Nao encontrado.");
        //    }

        //}
       
        protected void btCancelar_Click(object sender, EventArgs e)
        {
            // Pega a TID da venda
            PagamentoService.PagamentoServiceClient _pagamentoService = new PagamentoService.PagamentoServiceClient();
            var lista = _pagamentoService.listarFormaPagamento();

            //Pega o valor total da venda.
            var _formadePagamento = lista.Where(n => n.CODIGOREFERENCIA == Request["idReferencia"].ToString()).ToList();
           
            var vendavalor = _formadePagamento[0].VALOR.ToString();
            var tid = _formadePagamento[0].TID.ToString();

            string jsonCompra = Newtonsoft.Json.JsonConvert.SerializeObject(tid);


            var urlBase = @"https://sandbox-erede.useredecloud.com.br";
            var urlBaseConsulta = @"";

            var client = new RestClient(urlBase + "/v1/transactions/" + tid + "/refunds");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic OTg4MTI5NjA6MDM2ZWViNzBlNzc1NGIwZmE2ODdlMzg1M2U5MTZlNmY=");
            request.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" +
            @"  ""amount"": "+ vendavalor + "," + "\n" +
            @"  ""urls"": [" + "\n" +
            @"    {" + "\n" +
            @"      ""kind"": ""callback""," + "\n" +
            @"      ""url"": ""https://cliente.callback.com.br""" + "\n" +
            @"    }" + "\n" +
            @"  ]" + "\n" +
            @"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            dynamic _resultPayment = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);
            dynamic _resultComprar = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonCompra);

            //Se sucesso ao receber Salvar dados da venda.
            if (_resultPayment.returnCode.ToString() != null)
            {
                if (_resultPayment.returnCode.ToString() == "360" || _resultPayment.returnCode.ToString() == "359")
                {
                    var listavenda = _pagamentoService.listarPagamentos();

                    //Pega o valor total da venda.
                    var _registrovenda = listavenda.Where(n => n.CODIGOREFERENCIA == Request["idReferencia"].ToString()).ToList();

                    _pagamentoService.cancelarVenda(_registrovenda[0].ID);

                    PreencherDadosVenda();

                    Response.Write("A solicitação de Cancelamento foi realizada com Sucesso!");



                    //PagamentoService.PagamentoServiceClient service = new PagamentoService.PagamentoServiceClient();
                    ////int idProduto = getIdProduto();
                    //service.salvarRegistroPagamento(_resultPayment.reference.ToString(), idProduto.ToString(), ddlFormaPagamento.SelectedValue, ddlQuantidade.SelectedValue.ToString(), lvalortotal.Text);

                    //service.salvarRegistroFormaPagamento(_resultPayment.reference.ToString(), _resultPayment.amount.ToString(), _resultComprar.installmentes.ToString(),
                    //    _resultComprar.kind.ToString(), _resultPayment.returnCode.ToString(), _resultPayment.returnMessage.ToString(), _resultPayment.tid.ToString(),
                    //    _resultPayment.nsu.ToString(), _resultPayment.cardBin.ToString(), _resultPayment.authorizationCode.ToString(), _resultComprar.ToString(), _resultPayment.ToString());
                    //Response.Redirect("/detalheDeRecebimento.aspx?idReferencia=" + _resultPayment.reference.ToString());
                }
                else if (_resultPayment.returnCode.ToString() == "355")
                {
                    Response.Write("Transação já cancelada!");
                }
                else
                {
                    Response.Write("Codigo De Retorno:" + _resultPayment.returnCode.ToString() + ", Menssagem:" + _resultPayment.returnMessage.ToString());
                }
            }
            else
            {
                Response.Write("Sem reposta do Servidor, arguarde alguns minutos e tente novamente mais tarde!");
            }
            //Response.Redirect("/relatorioDeRecebimento.aspx");
        }

        private void ConverteListaString(List<REGISTROFORMAPAGAMENTO> lista)
        {
            throw new NotImplementedException();
        }

        protected void btExcluir_Click(object sender, EventArgs e)
        {


            Response.Redirect("/relatorioDeRecebimento.aspx");
        }
    }
}