using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Dev.Service
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IProdutoService" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IProdutoService
    {
        [OperationContract]
        List<PRODUTO> listarProdutos();

        [OperationContract]
        PRODUTO obterProduto(int idProduto);

        [OperationContract]
        void excluirProduto(int idProduto);

        [OperationContract]
        void salvarProduto(int idProduto, string nome, string valor, string quantidade);

       
    }
}
