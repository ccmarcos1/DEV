using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Dev.Service
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IUsuarioService" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IUsuarioService
    {
        [OperationContract]
        List<USUARIO> listarUsuarios();

        [OperationContract]
        USUARIO obterCliente(int idUsuario);

        [OperationContract]
        void excluirUsuario(int idUsuario);

        [OperationContract]
        void salvarUsuario(int idUsuario, string usuarioLogin, string senha, string nivel);
    }
}
