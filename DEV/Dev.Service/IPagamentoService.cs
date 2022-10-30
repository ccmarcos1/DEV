using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Dev.Service
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IPagamentoService" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IPagamentoService
    {
        [OperationContract]
        REGISTROVENDA obterCodigoReferencia(string codigo);

        [OperationContract]
        List<REGISTROVENDA> listarPagamentos();

        [OperationContract]
        List<REGISTROFORMAPAGAMENTO> listarFormaPagamento();

        [OperationContract]
        REGISTROVENDA obterPagamento(int idReferencia);


        [OperationContract]
        string consultaTID(string codigoReferencia);

        [OperationContract]
        void excluirPagamento(int idReferencia);

        [OperationContract]
        void salvarRegistroPagamento(string idCodigoReferencia, string nome, string tipo, string quantidade, string valor);

        [OperationContract]
        void salvarRegistroFormaPagamento(string idCodigoReferencia, string valor, string parcelas, string formaPagamento, string returnCode, string returnMessage, string tid, string nsu, string cardbin, string authorizationCode, string jsonvenda, string jsonreturn);

        [OperationContract]
        void cancelarVenda(int codreferencia); 
    }
}
