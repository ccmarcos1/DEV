<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DefaultMaster.Master" CodeBehind="default.aspx.cs" Inherits="DEV._default" %>

<asp:Content runat="server" ContentPlaceHolderID="Masterhead">
</asp:Content>
<asp:Content runat="server" class="formulario" ContentPlaceHolderID="ContentMain">
    <div class="card mb-4">
        <div class="card-header py-3">
            <asp:Label ID="ltitulo" class="m-0 font-weight-bold text-grandient-light" runat="server" Text="Cadastro Novo Usuario"></asp:Label>           
        </div>
        <div class="card-body">
            <div class="form-row">
                <div class="form-group col-md-5">
                    <label for="inputEmail4">Usuario</label>
                    <asp:TextBox ID="txtNome" class="form-control" runat="server" placeholder="Usuario"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-5">
                    <label for="inputEmail4">Senha</label>
                    <asp:TextBox ID="txtSenha" class="form-control" runat="server" placeholder="Senha"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-5">
                    <label for="inputState">State</label>
                    <asp:DropDownList ID="ddlNivel" class="form-control" runat="server">
                        <asp:ListItem Value="1">Administrador</asp:ListItem>
                        <asp:ListItem Value="2">Atendente</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div>
                <div>
                    <asp:Button ID="btSalvar" class="btn btn-success" runat="server"
                        Text="Salvar" OnClick="btSalvar_Click" />
                    <asp:Button ID="btExclui" class="btn btn-danger" runat="server"
                        Text="Excluir" OnClick="btExcluir_Click" />
                </div>
      
            </div>

        </div>
    </div>

</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentEnd">
</asp:Content>
