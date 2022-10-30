using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV.WEB
{
    public partial class relatorioDeRecebimento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PagamentoService.PagamentoServiceClient service = new PagamentoService.PagamentoServiceClient();
            var Pagamentos = service.listarPagamentos();
            rptUsuarios.DataSource = Pagamentos;
            rptUsuarios.DataBind();
        }
    }
}