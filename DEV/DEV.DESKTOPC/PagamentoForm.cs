using DEV.DESKTOPC.Models;
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
    public partial class PagamentoForm : Form
    {
        private int idProduto;
        public PagamentoForm(int IdProduto)
        {
            idProduto = IdProduto;
            InitializeComponent();
        }
        private void formapagamento()
        {
            cb_Formapagamento.Items.Add("credit");
            cb_Formapagamento.Items.Add("debit");
        }

        private void parcelas()
        {
            if (cb_Formapagamento.Text == "credit")
            {
                cb_parcela.Items.Clear();
                cb_parcela.Items.Add("1");
                cb_parcela.Items.Add( "2");
                cb_parcela.Items.Add("3");
                cb_parcela.Items.Add( "4");
                cb_parcela.Items.Add("5x");
                cb_parcela.Items.Add("6x");
                cb_parcela.Items.Add("7x");
                cb_parcela.Items.Add("8x");
                cb_parcela.Items.Add("9x");
                cb_parcela.Items.Add("10x");
                cb_parcela.Items.Add("11x");
                cb_parcela.Items.Add("12x");
            }
            else if (cb_Formapagamento.Text == "debit")
            {

                cb_parcela.Items.Clear();
                cb_parcela.Items.Add("0");
            }
        }
            private void PagamentoForm_Load(object sender, EventArgs e)
        {
            ProdutoService.ProdutoServiceClient service = new ProdutoService.ProdutoServiceClient();
            var produtos = service.obterProduto(idProduto);
            if (produtos != null)
            {
                txtNome.Text = produtos.NOME.ToString();
                txtValor.Text = produtos.VALOR.ToString();

                for(int i=1; i <= produtos.QUANTIDADE; i++)
                {
                    cb_Quantidade.Items.Add(i);
                }
            }
            formapagamento();
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

            if (pagamento == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void cb_Formapagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            parcelas();
        }
        private PagamentoRede Pagamento(PagamentoRede _pagamento)
        {

            _pagamento.reference = retornarCodigoReferenciaNovo(null);
            //_pagamento.capture = true;
            _pagamento.kind = cb_Formapagamento.Text; 
            _pagamento.amount = txtValor.Text.ToString();
            _pagamento.installmentes = cb_parcela.Text;
            //Dados do Cartao
            _pagamento.cardholderName = txtNomeR.Text;
            _pagamento.cardNumber = txtCard.Text;
            string Datavencimento = txtDataVenc.Text; // 06/22
            _pagamento.expirationMonth = Datavencimento.Remove(Datavencimento.Length - 3); //-> 06
            _pagamento.expirationYear = Datavencimento.Substring(Datavencimento.Length - 2); //-> 22
            _pagamento.securityCode = txtCVV.Text;
            _pagamento.softDescriptor = txtNome.Text;
            //_pagamento.subscription = false;
            //_pagamento.origin = "1";
            _pagamento.distributorAffiliation = "98812960";
            //_pagamento.brandTid = "string";
            //_pagamento.storageCard = "1";

            return _pagamento;
        }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            var _pagamento = new PagamentoRede();
            Pagamento(_pagamento);

            string jsonCompra = Newtonsoft.Json.JsonConvert.SerializeObject(_pagamento);


            var urlBase = @"https://sandbox-erede.useredecloud.com.br";
            var urlBaseConsulta = @"";

            var client = new RestClient(urlBase + "/v1/transactions");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic OTg4MTI5NjA6MDM2ZWViNzBlNzc1NGIwZmE2ODdlMzg1M2U5MTZlNmY=");
            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("application/json", jsonCompra, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            dynamic _resultPayment = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);
            dynamic _resultComprar = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonCompra);

            //Se sucesso ao receber Salvar dados da venda.
            if (_resultPayment.returnCode.ToString() == "00")
            {
                PagamentoService.PagamentoServiceClient service = new PagamentoService.PagamentoServiceClient();
                //int idProduto = getIdProduto();
                service.salvarRegistroPagamento(_resultPayment.reference.ToString(), idProduto.ToString(), cb_Formapagamento.Text, cb_Quantidade.Text, txtValor.Text);

                service.salvarRegistroFormaPagamento(_resultPayment.reference.ToString(), _resultPayment.amount.ToString(), _resultComprar.installmentes.ToString(),
                    _resultComprar.kind.ToString(), _resultPayment.returnCode.ToString(), _resultPayment.returnMessage.ToString(), _resultPayment.tid.ToString(),
                    _resultPayment.nsu.ToString(), _resultPayment.cardBin.ToString(), _resultPayment.authorizationCode.ToString(), _resultComprar.ToString(), _resultPayment.ToString());
                //Respo.Redirect("/detalheDeRecebimento.aspx?idReferencia=" + _resultPayment.reference.ToString() + "&idProduto=" + idProduto.ToString());
                MessageBox.Show("Venda Realizada Com Sucesso");
            }
            else
            {
                MessageBox.Show(_resultPayment.returnCode.ToString());
            }
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
