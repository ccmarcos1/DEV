using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV.DESKTOPC
{
    public partial class DetalheDeRecebimentoForm : Form
    {
        private int _idProduto;
        private string _CodigoReferencia;

        public DetalheDeRecebimentoForm(string CodigoReferencia, int IdProduto)
        {
            _CodigoReferencia = CodigoReferencia;
            _idProduto = IdProduto;
            InitializeComponent();
        }


        private void DetalheDeRecebimentoForm_Load(object sender, EventArgs e)
        {

            PreencherDadosVenda();
            ////Produto
            //ProdutoService.ProdutoServiceClient produto = new ProdutoService.ProdutoServiceClient();
            //var _produto = produto.obterProduto(_idProduto);

            //dgv_Produto.ColumnCount = 4;
            //dgv_Produto.Columns[0].Name = "ID";
            //dgv_Produto.Columns[1].Name = "PRODUTO";
            //dgv_Produto.Columns[2].Name = "Valor Por Un.";
            //dgv_Produto.Columns[3].Name = "Data de Cadastro";

            //dgv_Produto.Rows.Add(new object[] { _produto.ID, _produto.NOME,_produto.VALOR,
            //    _produto.DATAHORACRIACAO });


            ////this.dgv_Formapagamento.Columns["CustomerID"].Visible = false;
            ////Recebimento
            //PagamentoService.PagamentoServiceClient recebimento = new PagamentoService.PagamentoServiceClient();
            //var _recebimento = recebimento.obterCodigoReferencia(_CodigoReferencia);

            //dgv_Recebimento.ColumnCount = 6;
            //dgv_Recebimento.Columns[0].Name = "Codigo de Referencia";
            //dgv_Recebimento.Columns[1].Name = "Data de Recebimento";
            //dgv_Recebimento.Columns[2].Name = "Quantidade";
            //dgv_Recebimento.Columns[3].Name = "Valor";
            //dgv_Recebimento.Columns[4].Name = "Status";
            //dgv_Recebimento.Columns[5].Name = "Data de Cancelamento";

            //string status;
            //if (_recebimento.INATIVA == 0)
            //{
            //    status = "Cancelado";
            //}
            //else
            //{
            //    status = "Baixado";
            //}

            //dgv_Recebimento.Rows.Add(new object[] { _recebimento.CODIGOREFERENCIA, _recebimento.DATAHORA,
            //_recebimento.QUANTIDADE, _recebimento.VALOR,status, _recebimento.DATACANCELAMENTO
            //});

            ////Forma de Pagamento
            //PagamentoService.PagamentoServiceClient formapagamento = new PagamentoService.PagamentoServiceClient();
            //dgv_Formapagamento.DataSource = formapagamento.listarFormaPagamento().Where(c => c.CODIGOREFERENCIA == _CodigoReferencia).ToList();
            //OrdemColunaFormaPagamento();

        }
        private void OrdemColunaFormaPagamento()
        {
            //Ordem de apresentacao
            dgv_Formapagamento.Columns["FORMADEPAGAMENTO"].DisplayIndex = 0;
            dgv_Formapagamento.Columns["PARCELAS"].DisplayIndex = 1;
            dgv_Formapagamento.Columns["VALOR"].DisplayIndex = 2;
            dgv_Formapagamento.Columns["NSU"].DisplayIndex = 3;
            dgv_Formapagamento.Columns["AUTHORIZATIONCODE"].DisplayIndex = 4;
            dgv_Formapagamento.Columns["TID"].DisplayIndex = 5;
            //Colunas Ocultas
            dgv_Formapagamento.Columns["ID"].Visible = false;
            dgv_Formapagamento.Columns["CODIGOREFERENCIA"].Visible = false;
            dgv_Formapagamento.Columns["RETURNCODE"].Visible = false;
            dgv_Formapagamento.Columns["RETURNMESSAGE"].Visible = false;
            dgv_Formapagamento.Columns["CARDBIN"].Visible = false;
            dgv_Formapagamento.Columns["JSONVENDA"].Visible = false;
            dgv_Formapagamento.Columns["JSONRETURN"].Visible = false;
        }
        protected void PreencherDadosVenda()
        {
            PagamentoService.PagamentoServiceClient service = new PagamentoService.PagamentoServiceClient();
            var Pagamentos = service.listarPagamentos();
            dgv_Recebimento.DataSource = Pagamentos.Where(s => s.CODIGOREFERENCIA == _CodigoReferencia).ToList();
            
            var _dataCancelamento = Pagamentos.Where(n => n.CODIGOREFERENCIA == _CodigoReferencia).ToList();

            var data = _dataCancelamento[0].DATACANCELAMENTO.ToString();
            if (data != "01/01/2000 00:00:00")
            {
                btn_Cancelar.Visible = false;
            }
            else
            {
                btn_Cancelar.Visible = true;
            }
            ProdutoService.ProdutoServiceClient produtoService = new ProdutoService.ProdutoServiceClient();
            var produtos = produtoService.listarProdutos();
            dgv_Produto.DataSource = produtos.Where(s => s.ID == _idProduto).ToList();
            

            var Fromapagamento = service.listarFormaPagamento();
            dgv_Formapagamento.DataSource = Fromapagamento.Where(s => s.CODIGOREFERENCIA == _CodigoReferencia).ToList();
            OrdemColunaFormaPagamento();
            //btExclui.Text = "Excluir";
            //ltitulo.Text = "Detalhe de Recebimento - Referencia: " + Request["idReferencia"];
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            // Pega a TID da venda
            PagamentoService.PagamentoServiceClient _pagamentoService = new PagamentoService.PagamentoServiceClient();
            var lista = _pagamentoService.listarFormaPagamento();

            //Pega o valor total da venda.
            var _formadePagamento = lista.Where(c => c.CODIGOREFERENCIA == _CodigoReferencia).ToList();

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
            @"  ""amount"": " + vendavalor + "," + "\n" +
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
                    var _registrovenda = listavenda.Where(c => c.CODIGOREFERENCIA == _CodigoReferencia).ToList();

                    _pagamentoService.cancelarVenda(_registrovenda[0].ID);

                    PreencherDadosVenda();


                    MessageBox.Show("A solicitação de Cancelamento foi realizada com Sucesso!");


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
                    MessageBox.Show("Transação já cancelada!");
                }
                else
                {
                    MessageBox.Show("Codigo De Retorno:" + _resultPayment.returnCode.ToString() + ", Menssagem:" + _resultPayment.returnMessage.ToString());
                }
            }
            else
            {
                MessageBox.Show("Sem reposta do Servidor, arguarde alguns minutos e tente novamente mais tarde!");
            }
            //Response.Redirect("/relatorioDeRecebimento.aspx");
        }
    }
}
