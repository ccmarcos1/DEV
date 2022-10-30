<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DefaultMaster.Master" CodeBehind="produtoLista.aspx.cs" Inherits="Pagamento.produtoLista" %>

<asp:Content runat="server" ContentPlaceHolderID="Masterhead">
</asp:Content>
<asp:Content runat="server" class="formulario" ContentPlaceHolderID="ContentMain">

    <div class="card shadow mb-4">
        <div class="card-header py-3">
             <div class="form-row">
                 <div class="form-group col-md-5">
                <h6 class="m-0 font-weight-bold text-gradient-light">Registro de Produtos</h6>
                     </div>
            </div>
             <div class="form-row">
                 <div class="form-group col-md-5">
                <asp:LinkButton runat="server" ID="novoUsuario" href="produtoForm.aspx" class="btn btn-success col-md-2">Novo</asp:LinkButton>
                     </div>
            </div>
        </div>

        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-bordered" id="dtusuario" width="100%" cellspacing="0">
                    <thead>
                        <tr>
                            <th>Nome</th>
                            <th>Preco</th>
                            <th>Quantidade em Estoque</th>
                            <th>Data de Registro</th>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="rptUsuarios">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <a class=" text-success" href="produtoForm.aspx?idProduto=<%# Eval("ID")%>">
                                            <%# Eval("NOME")%>
                                        </a>
                                    </td>
                                    <td><%# "R$ " %> <%# Eval("VALOR").ToString() %></td>
                                    <td><%# Eval("QUANTIDADE") %></td>
                                    <td><%# Eval("DATAHORACRIACAO") %> </td>
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
