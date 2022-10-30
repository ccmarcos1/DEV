<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DefaultMaster.Master" CodeBehind="pagamentoForm.aspx.cs" Inherits="Pagamento.pagamentoForm" %>

<asp:Content runat="server" ContentPlaceHolderID="Masterhead">
</asp:Content>
<asp:Content runat="server" class="formulario" ContentPlaceHolderID="ContentMain">
    <div class="card mb-4">
        <div class="card-header py-3">
            <asp:Label ID="ltitulo" class="m-0 font-weight-bold text-grandient-light" runat="server" Text="Recebimento"></asp:Label>           
        </div>
        <div class="card-body">
            <div class="form-row">
                <div class="form-group col-md-5">
                    <label for="inputEmail4">Nome Produto:</label>
                    <asp:TextBox ID="txtNome" class="form-control" runat="server" placeholder="Nome"></asp:TextBox>
                </div>           
                <div class="form-group col-md-5">
                    <label for="inputEmail4">Preco por Unidade:</label>
                    <asp:TextBox ID="txtValor" class="form-control" runat="server" placeholder="Valor"></asp:TextBox>
                </div>
            </div>
             <div class="form-row">
                <div class="form-group col-md-2">
                    <label for="inputEmail4">Quantidade:</label>
                    <asp:TextBox ID="txtQuantidade" class="form-control" runat="server" placeholder="Quantidade"></asp:TextBox>
                </div>
            </div>
            <hr >
                <asp:Label ID="Label1" class="m-0 font-weight-bold text-grandient-light" runat="server" Text="Dados da Forma de Pagamento:"></asp:Label>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputAddress">Nome do Responsavel:</label>
                        <input type="text" class="form-control" id="inNome" placeholder="ex: Jose francisco">
                    </div>
                    <div class="form-group col-md-4">
                        <label for="inTipoCard">Forma de Pagamento:</label>
                        <select id="sTipoCard" class="form-control">
                            <option value="1" selected>Credito</option>
                            <option value="2">Debito</option>
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
                 <asp:Button ID="btExclui" class="btn btn-danger" runat="server"
                        Text="Cancelar" OnClick="btExcluir_Click" />
            </div>
            </div>        

     

</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentEnd">
</asp:Content>
