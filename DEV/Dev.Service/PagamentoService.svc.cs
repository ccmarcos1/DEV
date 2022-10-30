using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Dev.Service
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "PagamentoService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione PagamentoService.svc ou PagamentoService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class PagamentoService : IPagamentoService
    {

        public string consultaTID(string codigoreferencia)
        {
            contextoDBDataContext context = new contextoDBDataContext();
            var pagamento = obterCodigoFormaPagamentoInterno(codigoreferencia, context);
            return pagamento.TID.ToString();

        }
        private REGISTROVENDA obterPagamentoInterno(int idPagamento, contextoDBDataContext context)
        {
            var Pagamento = (from c in context.REGISTROVENDA
                             where
                           c.ID == idPagamento
                             select c)
                      .FirstOrDefault();
            return Pagamento;
        }
        private REGISTROVENDA obterCodigoPagamentoInterno(string codigo, contextoDBDataContext context)
        {
            var Pagamento = (from c in context.REGISTROVENDA
                             where
                           c.CODIGOREFERENCIA == codigo
                             select c)
                      .FirstOrDefault();
            return Pagamento;
        }
        private REGISTROFORMAPAGAMENTO obterCodigoFormaPagamentoInterno(string codigo, contextoDBDataContext context)
        {
            var Pagamento = (from c in context.REGISTROFORMAPAGAMENTO
                             where
                           c.CODIGOREFERENCIA == codigo
                             select c)
                      .FirstOrDefault();
            return Pagamento;
        }
        public List<REGISTROVENDA> listarPagamentos()
        {
            contextoDBDataContext context = new contextoDBDataContext();


            var Pagamento = (from c in context.REGISTROVENDA
                             select c)
                            .OrderBy(c => c.ID)
                            .ToList();
            return Pagamento;

        }
        public List<REGISTROFORMAPAGAMENTO> listarFormaPagamento()
        {
            contextoDBDataContext context = new contextoDBDataContext();


            var Pagamento = (from c in context.REGISTROFORMAPAGAMENTO
                             select c)
                            .OrderBy(c => c.ID)
                            .ToList();
            return Pagamento;

        }

        public REGISTROVENDA obterPagamento(int idPagamento)
        {
            contextoDBDataContext context = new contextoDBDataContext();
            var Pagamento = obterPagamentoInterno(idPagamento, context);
            return Pagamento;
        }
        public REGISTROVENDA obterCodigoReferencia(string codigo)
        {
            contextoDBDataContext context = new contextoDBDataContext();
            var Pagamento = obterCodigoPagamentoInterno(codigo, context);
            return Pagamento;
        }
        public void excluirPagamento(int idPagamento)
        {
            contextoDBDataContext context = new contextoDBDataContext();

            var Pagamento = obterPagamentoInterno(idPagamento, context);
            if (Pagamento != null)
            {
                context.REGISTROVENDA.DeleteOnSubmit(Pagamento);
                context.SubmitChanges();
            }

        }
        public void salvarRegistroPagamento(string idCodigoReferencia, string idproduto, string tipo, string quantidade, string valor)
        {
            contextoDBDataContext context = new contextoDBDataContext();

            ProdutoService service = new ProdutoService();
            var produtos = service.listarProdutos();
            var produtoEstoque = produtos.Where(n => n.ID == int.Parse(idproduto)).ToList();

            if (produtoEstoque[0].QUANTIDADE > 0)
            {
                var quantidadevenda = produtoEstoque[0].QUANTIDADE - Convert.ToInt32(quantidade);
                service.salvarProduto(int.Parse(idproduto), produtoEstoque[0].NOME.ToString(), produtoEstoque[0].VALOR.ToString(), quantidadevenda.ToString());


                REGISTROVENDA Pagamento = new REGISTROVENDA();
                context.REGISTROVENDA.InsertOnSubmit(Pagamento);

                Pagamento.CODIGOREFERENCIA = idCodigoReferencia;
                Pagamento.IDPRODUTO = idproduto;
                Pagamento.TIPO = tipo;
                Pagamento.QUANTIDADE = quantidade;
                Pagamento.VALOR = valor;
                Pagamento.DATAHORA = DateTime.Now;
                Pagamento.INATIVA = 0;

                DateTime dataPadrao = new DateTime(2000, 01, 01);
                Pagamento.DATACANCELAMENTO = dataPadrao;

                context.SubmitChanges();
            }
            else
            {
                Console.Write("Produto nao esta mais disponivel para recebimento. Por favor verificar estoque!");
            }

        }
        public void salvarRegistroFormaPagamento(string idCodigoReferencia, string valor, string parcelas, string formaPagamento, string returnCode, string returnMessage, string tid, string nsu, string cardbin, string authorizationCode, string jsonvenda, string jsonreturn)
        {
            contextoDBDataContext context = new contextoDBDataContext();
            REGISTROFORMAPAGAMENTO _formaPagamento = new REGISTROFORMAPAGAMENTO();

            context.REGISTROFORMAPAGAMENTO.InsertOnSubmit(_formaPagamento);

            _formaPagamento.CODIGOREFERENCIA = idCodigoReferencia;
            _formaPagamento.VALOR = valor;
            _formaPagamento.PARCELAS = parcelas;
            _formaPagamento.FORMADEPAGAMENTO = formaPagamento;
            _formaPagamento.RETURNCODE = returnCode;
            _formaPagamento.RETURNMESSAGE = returnMessage;
            _formaPagamento.TID = tid;
            _formaPagamento.NSU = nsu;
            _formaPagamento.CARDBIN = cardbin;
            _formaPagamento.AUTHORIZATIONCODE = authorizationCode;
            _formaPagamento.JSONVENDA = jsonvenda;
            _formaPagamento.JSONRETURN = jsonreturn;

            context.SubmitChanges();
        }
        public void cancelarVenda(int idvenda)
        {
            contextoDBDataContext context = new contextoDBDataContext();
            REGISTROVENDA venda = null;
            if (idvenda == -1)
            {
                Console.Write("venda nao encontrada");
                //venda = new REGISTROVENDA();
                //context.REGISTROVENDA.InsertOnSubmit(venda);

            }
            else
            {

                venda = obterPagamentoInterno(idvenda, context);
                ProdutoService service = new ProdutoService();
                var produtos = service.listarProdutos();
                var produtoEstoque = produtos.Where(n => n.ID == int.Parse(venda.IDPRODUTO)).ToList();

                if (produtoEstoque[0].QUANTIDADE != null)
                {
                    var quantidadevenda = produtoEstoque[0].QUANTIDADE + Convert.ToInt32(venda.QUANTIDADE);
                    service.salvarProduto(int.Parse(venda.IDPRODUTO), produtoEstoque[0].NOME.ToString(), produtoEstoque[0].VALOR.ToString(), quantidadevenda.ToString());
                }
            }
            venda.INATIVA = 1;
            venda.DATACANCELAMENTO = DateTime.Now;
            context.SubmitChanges();

        }
    }

}

