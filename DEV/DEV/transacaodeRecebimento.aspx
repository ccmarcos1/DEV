<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DefaultMaster.Master" CodeBehind="transacaodeRecebimento.aspx.cs" Inherits="DEV.transacaodeRecebimento" %>

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
  <hr />
            <div class="form-row">
                <div class="form-group col-md-5">
                    <h6 class="m-0 font-weight-bold text-gradient-light">Filtrar por:</h6>
                </div>
              </div>
             <div class="form-row">
              <div class="form-group col-md-4">
                        <label for="inTipoCard">Data Inicio:</label>
                        <select id="inInicio" class="form-control">
                            <option value="Credit" selected><%=DateTime.Now %></option>
                            <option value="Debit">Debito</option>
                        </select>
                    </div>
                  <div class="form-group col-md-4">
                        <label for="inTipoCard">Data Fim:</label>
                        <select id="inFim" class="form-control">
                            <option value="Credit" selected><%=DateTime.Now %></option>
                            <option value="Debit">Debito</option>
                        </select>
                    </div>
                 </div>
                 <button type="submit" class="btn btn-success">Filtrar</button>
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
                                        <a class=" text-success" href="pagamentoForm.aspx?idProduto=<%# Eval("ID")%>">
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

