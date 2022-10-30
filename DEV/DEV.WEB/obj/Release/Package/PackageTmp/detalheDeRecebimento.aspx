<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DefaultMaster.Master" CodeBehind="detalheDeRecebimento.aspx.cs" Inherits="DEV.WEB.detalheDeRecebimento" %>

<asp:Content runat="server" ContentPlaceHolderID="Masterhead">
</asp:Content>
<asp:Content runat="server" class="formulario" ContentPlaceHolderID="ContentMain">
    <div class="card mb-4">
        <div class="card-header py-3">
            <asp:Label ID="ltitulo" class="m-0 font-weight-bold text-grandient-light" runat="server" Text=""></asp:Label>

        </div>
        <div class="card-header py-3">
            <asp:Label ID="lRegistro" class="m-0 font-weight-bold text-grandient-light" runat="server" Text="Registro Do Recebimento:"></asp:Label>


            <div class="card-body">
                <div class="table-responsive">
                    <table class="table table-bordered" id="dtRegistroRecebimento" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>Codigo de Referencia</th>
                                 <th>Data de Recebimento</th>
                                <th>ID do Produto</th>
                                <th>Quantidade</th>
                                <th>Preco Total</th>
                                <th>Forma De Pagamento</th>
                                <th>Status da Venda</th>
                                <th>Data de Cancelamento</th>

                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater runat="server" ID="rptUsuarios">
                                <ItemTemplate>
                                    <tr>
                                        <td class=" text-success">

                                            <%# Eval("CODIGOREFERENCIA")%>
                                           
                                        </td>
                                          <td><%# Eval("DATAHORA") %> </td>
                                        <td>
                                            <%# Eval("IDPRODUTO")%>
                                        </td>
                                        <td>
                                            <%# Eval("QUANTIDADE")%>
                                        </td>
                                        <td><%# "R$ " %> <%#  Eval("VALOR").ToString().Insert(Eval("VALOR").ToString().Length - 2, ",") %></td>
                                        <td><%# Eval("TIPO").ToString() == "credit" ? "CREDITO" : "DEBITO" %></td>
                                        <td><%# Eval("INATIVA").ToString() == "0" ? "Baixado" : "Cancelado"  %></td>
                                        <td><%#  Eval("DATACANCELAMENTO").ToString() == "01/01/2000 00:00:00" ? "" : Eval("DATACANCELAMENTO") %> </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>

                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class="card-header py-3">
            <asp:Label ID="Label2" class="m-0 font-weight-bold text-grandient-light" runat="server" Text="Dados do Produto:"></asp:Label>


            <div class="card-body">
                <div class="table-responsive">
                    <table class="table table-bordered" id="dtRegistroRecebimento" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>ID do Produto</th>
                                <th>Produto</th>
                                <th>Preco Por Unidade</th>
                                <th>Data de Recebimento</th>

                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater runat="server" ID="rptProdutos">
                                <ItemTemplate>
                                    <tr>
                                        <td class=" text-success">

                                            <%# Eval("ID")%>
                                           
                                        </td>
                                        <td class=" text-success">

                                            <%# Eval("NOME")%>
                                           
                                        </td>
                                        <td><%# "R$ " %> <%#  Eval("VALOR").ToString().Insert(Eval("VALOR").ToString().Length - 2, ",") %></td>
                                        <td><%# Eval("DATAHORACRIACAO") %> </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>

                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class="card-header py-3">
            <asp:Label ID="Label1" class="m-0 font-weight-bold text-grandient-light" runat="server" Text="Forma de Pagamento:"></asp:Label>


            <div class="card-body">
                <div class="table-responsive">
                    <table class="table table-bordered" id="dtFormaPagamento" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>Forma De Pagmaneto</th>
                                <th>Parcelas</th>
                                <th>NSU</th>
                                <th>Autorização</th>
                                <th>TID</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater runat="server" ID="rptFormaPagamento">
                                <ItemTemplate>
                                    <tr>
                                        <td>

                                            <%# Eval("FORMADEPAGAMENTO").ToString() == "credit" ? "CREDITO" : "DEBITO" %>
 
                                        </td>
                                        <td><%# Eval("PARCELAS").ToString() == "1" ? "A vista" : Eval("PARCELAS") + "x"%></td>
                                        <td><%# Eval("NSU") %></td>
                                        <td><%# Eval("AUTHORIZATIONCODE")%></td>
                                        <td><%# Eval("TID")%></td>

                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>

                        </tbody>
                    </table>

                    <%--    <div class="card-body">--%>
                    <asp:Button ID="btExclui" class=" btn btn-danger" runat="server"
                        Text="Cancelar Recebimento"  OnClick="btCancelar_Click" />
                    <%--     </div>--%>
                </div>
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
        $(document).ready(function () {
            $('#rptformapagamento').DataTable();
        });
    </script>
</asp:Content>
