using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV.WEB
{
    public partial class recebimentoVendas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProdutoService.ProdutoServiceClient service = new ProdutoService.ProdutoServiceClient();
            var produtos = service.listarProdutos();
            rptUsuarios.DataSource = produtos;
            rptUsuarios.DataBind();
        }
    }
}