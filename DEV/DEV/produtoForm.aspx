<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DefaultMaster.Master" CodeBehind="produtoForm.aspx.cs" Inherits="DEV.produtoForm" %>

<asp:Content runat="server" ContentPlaceHolderID="Masterhead">
</asp:Content>
<asp:Content runat="server" class="formulario" ContentPlaceHolderID="ContentMain">
    <div class="card mb-4">
        <div class="card-header py-3">
            <asp:Label ID="ltitulo" class="m-0 font-weight-bold text-grandient-light" runat="server" Text="Cadastro Novo Produto"></asp:Label>           
        </div>
        <div class="card-body">
            <div class="form-row">
                <div class="form-group col-md-5">
                    <label for="inputEmail4">Usuario</label>
                    <asp:TextBox ID="txtNome" class="form-control" runat="server" placeholder="Nome"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-5">
                    <label for="inputEmail4">Preco</label>
                    <asp:TextBox ID="txtValor" class="form-control" runat="server" placeholder="Valor"></asp:TextBox>
                </div>
            </div>
             <div class="form-row">
                <div class="form-group col-md-5">
                    <label for="inputEmail4">Quantidade</label>
                    <asp:TextBox ID="txtQuantidade" class="form-control" runat="server" placeholder="Quantidade"></asp:TextBox>
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
