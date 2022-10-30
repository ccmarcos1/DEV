<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DefaultMaster.Master" CodeBehind="recebimentoVendas.aspx.cs" Inherits="DEV.recebimentoVendas" %>

<asp:Content runat="server" ContentPlaceHolderID="Masterhead">
</asp:Content>
<asp:Content runat="server" class="formulario" ContentPlaceHolderID="ContentMain">

    <div class="card shadow mb-4">
        <div class="card-header py-3">
            <div class="form-row">
                <div class="form-group col-md-5">
                    <h6 class="m-0 font-weight-bold text-gradient-light">Recebimento de Produtos</h6>
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
                            <th>Acao</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="rptUsuarios">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <a class=" text-success" href="pagamentoForm.aspx?idProduto=<%# Eval("ID")%>">
                                            <%# Eval("NOME")%>
                                        </a>
                                    </td>
                                    <td><%# "R$ " %> <%# Eval("VALOR").ToString() %></td>
                                    <td><%# Eval("QUANTIDADE") %></td>
                                    <td><%# Eval("DATAHORACRIACAO") %> </td>
                                    <td>
                                      
                                             <a class=" text-success" href="pagamentoForm.aspx?idProduto=<%# Eval("ID")%>">
                                           Receber
                                        </a>                                   
                                    </td>
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

           <%--         
                </div>
            </div>
            <div class="card-header py-3">
                <asp:Label ID="Label1" class="m-0 font-weight-bold text-grandient-light" runat="server" Text="Dados da Forma de Pagamento:"></asp:Label>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputAddress">Nome do Responsavel:</label>
                        <input type="text" class="form-control" id="inNome" placeholder="ex: Jose francisco">
                    </div>
                    <div class="form-group col-md-4">
                        <label for="inTipoCard">Forma de Pagamento:</label>
                        <select id="inTipoCard" class="form-control">
                            <option value="Credit" selected>Credito</option>
                            <option value="Debit">Debito</option>
                        </select>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputAddress2">Numero do Cartao:</label>
                        <input type="text" class="form-control" id="inNumeroCartao" placeholder="ex: 5448 2800 0000 0007">
                    </div>
                    <div class="form-group col-md-2">
                        <label for="inputAddress2">Data de Venc.:</label>
                        <input type="text" class="form-control" id="inMesAno" placeholder="ex: 06/22">
                    </div>
                    <div class="form-group col-md-1">
                        <label for="inputCity">CVV:</label>
                        <input type="text" class="form-control" id="inCVV" placeholder="ex: 123">
                    </div>
                </div>
                <button type="submit" class="btn btn-success">Receber</button>
            </div>

        </div>
    </div>--%>



