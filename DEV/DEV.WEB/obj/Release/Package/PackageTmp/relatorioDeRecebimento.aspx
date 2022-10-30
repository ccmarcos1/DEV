<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DefaultMaster.Master" CodeBehind="relatorioDeRecebimento.aspx.cs" Inherits="DEV.WEB.relatorioDeRecebimento" %>

<asp:Content runat="server" ContentPlaceHolderID="Masterhead">
</asp:Content>
<asp:Content runat="server" class="formulario" ContentPlaceHolderID="ContentMain">

    <div class="card shadow mb-4">
        <div class="card-header py-3">
            <div class="form-row">
                <div class="form-group col-md-5">
                    <h6 class="m-0 font-weight-bold text-gradient-light">Relatorio de Recebimento</h6>
                </div>
            </div>
            <%--  <div class="form-row">
                 <div class="form-group col-md-5">
                <asp:LinkButton runat="server" ID="novoUsuario" href="produtoForm.aspx" class="btn btn-success col-md-2">Novo</asp:LinkButton>
                     </div>
            </div>--%>
        </div>

        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-bordered" id="dtusuario" width="100%" cellspacing="0">
                    <thead>
                        <tr>

                            
                            <th>Codigo de Referencia</th>
                            <th>Data de Recebimento</th>
                            <th>Preco</th>
                            <th>Forma De Pagamento</th>
                            <th>Status</th>
                            <th>Data de Cancelamento</th>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="rptUsuarios">
                            <ItemTemplate>
                                <tr>
                                   
                                    <td>
                                        
                                        <a class=" text-success" href="detalheDeRecebimento.aspx?idReferencia=<%# Eval("CODIGOREFERENCIA")%>&idProduto=<%# Eval("IDPRODUTO")%>">
                                            <%# Eval("CODIGOREFERENCIA")%>
                                        </a>
                                    </td>
                                     <td><%# Eval("DATAHORA") %> </td>
                                    <td><%# "R$ " %> <%# Eval("VALOR").ToString().Insert(Eval("VALOR").ToString().Length - 2, ",") %></td>
                                    <td><%# Eval("TIPO").ToString() == "credit" ? "CREDITO" : "DEBITO" %></td>
                                    <td><%# Eval("INATIVA").ToString() == "0" ? "BAIXADO" : "CANCELADO" %></td>
                                     <td><%# Eval("DATACANCELAMENTO").ToString() == "01/01/2000 00:00:00" ? "" : Eval("DATACANCELAMENTO") %> </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>

                    </tbody>
                </table>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentEnd">
    <script>
        // Call the dataTables jQuery plugin
        $(document).ready(function () {
            $('#dtusuario').DataTable();
        });

    </script>
</asp:Content>
