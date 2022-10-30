<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DefaultMaster.Master" CodeBehind="usuarioLista.aspx.cs" Inherits="Pagamento.usuarioLista" %>

<asp:Content runat="server" ContentPlaceHolderID="Masterhead">
</asp:Content>
<asp:Content runat="server" class="formulario" ContentPlaceHolderID="ContentMain">

    <div class="card shadow mb-4">
        <div class="card-header py-3">
             <div class="form-row">
                 <div class="form-group col-md-5">
                <h6 class="m-0 font-weight-bold text-gradient-light">Registro de Usuarios</h6>
                     </div>
            </div>
             <div class="form-row">
                 <div class="form-group col-md-5">
                <asp:LinkButton runat="server" ID="novoUsuario" href="default.aspx" class="btn btn-success col-md-2">Novo</asp:LinkButton>
                     </div>
            </div>
        </div>

        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-bordered" id="dtusuario" width="100%" cellspacing="0">
                    <thead>
                        <tr>
                            <th>Usuario</th>
                            <th>Senha</th>                            
                            <th>Nivel de Acesso</th>
                            <th>Data de Registro</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="rptUsuarios">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <a class=" text-success" href="default.aspx?idUsuario=<%# Eval("ID")%>">
                                            <%# Eval("USUARIO1")%>
                                        </a>
                                    </td>
                                    <td > ***** </td>
                                    <td><%# Eval("NIVEL").ToString() == "1" ? "Administrador" : "Atendente" %> </td>
                                    <td><%# Eval("DATACRIACAO") %></td>
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
