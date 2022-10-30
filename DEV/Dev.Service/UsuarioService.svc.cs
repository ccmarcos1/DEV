using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Dev.Service
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "UsuarioService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione UsuarioService.svc ou UsuarioService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class UsuarioService : IUsuarioService
    {
        private USUARIO obterUsuarioInterno(int idUsuario, contextoDBDataContext context)
        {
            var usuario = (from c in context.USUARIO
                           where
                           c.ID == idUsuario
                           select c)
                      .FirstOrDefault();
            return usuario;
        }

        public List<USUARIO> listarUsuarios()
        {
            contextoDBDataContext context = new contextoDBDataContext();
            var usuarios = (from c in context.USUARIO
                            select c)
                            .OrderBy(c => c.USUARIO1)
                            .ToList();
            return usuarios;

        }
        public USUARIO obterCliente(int idUsuario)
        {
            contextoDBDataContext context = new contextoDBDataContext();
            var usuario = obterUsuarioInterno(idUsuario, context);
            return usuario;
        }

        public void excluirUsuario(int idUsuario)
        {
            contextoDBDataContext context = new contextoDBDataContext();

            var usuario = obterUsuarioInterno(idUsuario, context);
            if (usuario != null)
            {
                context.USUARIO.DeleteOnSubmit(usuario);
                context.SubmitChanges();
            }

        }
        public void salvarUsuario(int idUsuario, string usuarioLogin, string senha,string nivel)
        {
            contextoDBDataContext context = new contextoDBDataContext();
            USUARIO usuario = null;
            if (idUsuario == -1)
            {
                usuario = new USUARIO();
                context.USUARIO.InsertOnSubmit(usuario);

            }
            else
            {
                 usuario = obterUsuarioInterno(idUsuario, context);

            }
            usuario.USUARIO1 = usuarioLogin;
            usuario.SENHA = senha;
            usuario.DATACRIACAO = DateTime.Now;

            usuario.NIVEL = Int32.Parse(nivel);
            context.SubmitChanges();
        }
    }
}
