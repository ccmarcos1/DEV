using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV
{
    public partial class usuarioLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioService.UsuarioServiceClient service = new UsuarioService.UsuarioServiceClient();
            var usuarios = service.listarUsuarios();
            rptUsuarios.DataSource = usuarios;
            rptUsuarios.DataBind();
        }
    }
}