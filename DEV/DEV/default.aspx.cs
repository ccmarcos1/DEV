using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV
{
    public partial class _default : System.Web.UI.Page
    {
        private int getIdUsuario()
        {
            int idUsuario = -1;
            if (Request["idUsuario"] != null)
            {
                //se for diferente de nulo tenta converte ele para um valor inteiro se conseguir converte - alimenta a variavel.
                int.TryParse(Request["idUsuario"].ToString(), out idUsuario);
            }
            return idUsuario;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request["idUsuario"] != null)
                {
                    carregarDadosUsuario();
                    btExclui.Text = "Excluir";
                    ltitulo.Text = "Modificacao de Usuario";
                }
                else
                {
                    btExclui.Text = "Cancelar";
                    ltitulo.Text = "Registro de Usuarios";
                }
            }
          
          
                
            
          

        }
        protected UsuarioService.USUARIO obterCliente()
        {
            
            int idUsuario = -1;
            if (Request["idUsuario"] != null)
            {
                //se for diferente de nulo tenta converte ele para um valor inteiro se conseguir converte - alimenta a variavel.
                int.TryParse(Request["idUsuario"].ToString(), out idUsuario);
            }

            UsuarioService.UsuarioServiceClient service = new UsuarioService.UsuarioServiceClient();
            UsuarioService.USUARIO usuario = service.obterCliente(idUsuario);
            return usuario;
        }

        protected void carregarDadosUsuario()
        {
           
            // Request para pega o idusuario da URL.
            var usuario = obterCliente();
            if (usuario != null)
            {
                txtNome.Text = usuario.USUARIO1;
                txtSenha.Text = usuario.SENHA;
                ddlNivel.SelectedValue = usuario.NIVEL.ToString();
            }
            else
            {
                Response.Write("Cliente Nao encontrado.");
            }

        }
      
        protected void btSalvar_Click(object sender, EventArgs e)
        {      
            int idUsuario = getIdUsuario();
            UsuarioService.UsuarioServiceClient service = new UsuarioService.UsuarioServiceClient();
            service.salvarUsuario(idUsuario, txtNome.Text,txtSenha.Text, ddlNivel.SelectedValue);

            Response.Redirect("/usuarioLista.aspx");
        }
        protected void btExcluir_Click(object sender, EventArgs e)
        {
            int idUsuario = getIdUsuario();
            UsuarioService.UsuarioServiceClient service = new UsuarioService.UsuarioServiceClient();
            service.excluirUsuario(idUsuario);

            Response.Redirect("/usuarioLista.aspx");
        }

    }
}