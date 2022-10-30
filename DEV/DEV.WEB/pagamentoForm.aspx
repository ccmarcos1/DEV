<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DefaultMaster.Master" CodeBehind="pagamentoForm.aspx.cs" Inherits="DEV.WEB.pagamentoForm" %>


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
                    <label for="lproduto">Nome Produto:</label>
                    <asp:Label class="text-success" ID="lProduto" runat="server" Text="valortotal"></asp:Label>
                </div>

            </div>
            <div class="form-row">
                <div class="form-group col-md-2">
                    <label for="inputEmail4">Quantidade:</label>
                    <%--<asp:TextBox ID="txtQuantidade" class="form-control" runat="server" placeholder="Quantidade"></asp:TextBox>--%>
                    <asp:DropDownList class="btn btn-success dropdown-toggle dropdown-toggle-split" OnSelectedIndexChanged="ddlQuantidade_SelectedIndexChanged" AutoPostBack="true" ID="ddlQuantidade" runat="server"></asp:DropDownList>
                </div>
                <div class="form-group col-md-2">
                    <label for="inputEmail4">Valor Total:<a class="text-success"> R$ </a></label>
                    <asp:Label class="text-success" ID="lvalortotal" runat="server" Text="valortotal"></asp:Label>
                </div>
            </div>

            <hr>
            <asp:Label ID="Label1" class="m-0 font-weight-bold text-grandient-light" runat="server" Text="Dados da Forma de Pagamento:"></asp:Label>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputAddress">Nome do Responsavel:</label>
                    <asp:TextBox ID="txtNome" RequiredFieldValidator="" class="form-control" runat="server" placeholder="ex: Jose francisco"></asp:TextBox>
                    <%--   <input type="text" class="form-control" id="inNome" placeholder="ex: Jose francisco">--%>
                </div>
                <div class="form-group col-md-2">
                    <div>
                        <label for="inTipoCard">Forma de Pagamento:</label>
                    </div>

                    <div>
                        <asp:DropDownList class="btn btn-success dropdown-toggle dropdown-toggle-split" OnSelectedIndexChanged="ddlFormaPagamento_SelectedIndexChanged" AutoPostBack="true" ID="ddlFormaPagamento" runat="server"></asp:DropDownList>

                    </div>
                </div>
                <div class="form-group col-md-2">
                    <div>
                        <label for="inTipoCard">Parcelas:</label>
                    </div>
                    <div>
                        <asp:DropDownList class="btn btn-success dropdown-toggle dropdown-toggle-split" AutoPostBack="true" ID="ddlParcelas" runat="server"></asp:DropDownList>
                    </div>
                </div>

            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputAddress2">Numero do Cartao:</label>
                    <asp:TextBox ID="txtCardNumber" MaxLength="16" class="form-control" runat="server" placeholder="ex: 5448 2800 0000 0007"></asp:TextBox>
                    <%--<input type="text" class="form-control" id="inNumeroCartao" placeholder="ex: 5448 2800 0000 0007">--%>
                </div>

                <div class="form-group col-md-2">

                    <label for="inputAddress2">Data de Venc.:</label>
                    <asp:TextBox MaxLength="5" ID="txtVencimento" class="form-control" runat="server" placeholder="ex: 06/22"></asp:TextBox>
                    <%-- <input type="text" class="form-control" id="inMesAno" placeholder="ex: 06/22">--%>
                </div>
                <div class="form-group col-md-1">
                    <label for="inputCity">CVV:</label>

                    <asp:TextBox ID="txtCVV" MaxLength="3" class="form-control" runat="server" placeholder="ex: 123"></asp:TextBox>
                    <%--<input type="text" class="form-control" id="inCVV" placeholder="ex: 123">--%>
                </div>
            </div>
            <asp:Button ID="btnReceber" OnClientClick=" return validate()" runat="server"
                Text="Confirmar" OnClick="btSalvar_Click" class="btn btn-success" />
            <asp:Button ID="btExclui" class="btn btn-danger" runat="server"
                Text="Cancelar" OnClick="btCancelar_Click" />
        </div>
    </div>



</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentEnd">
    <script>
        function validate() {
            var mensagem = "";
            if (document.getElementById("<%=txtNome.ClientID%>").value == "") {
                mensagem += "Informe o Nome Do Reponsavel.";
                document.getElementById("<%=txtNome.ClientID%>").focus();

            }
            if (document.getElementById("<%=txtCardNumber.ClientID%>").value == "") {
                mensagem += "\n Informe o Numero do Cartao.";
                document.getElementById("<%=txtCardNumber.ClientID%>").focus();

            }
            if (document.getElementById("<%=txtCVV.ClientID%>").value == "") {
                mensagem += "\n Informe o CVV.";
                document.getElementById("<%=txtCVV.ClientID%>").focus();

            }
            if (document.getElementById("<%=txtVencimento.ClientID%>").value == "") {
                mensagem += "\n Informe a Data de Vencimento.";
                document.getElementById("<%=txtVencimento.ClientID%>").focus();

            }
            if (document.getElementById("<%=ddlQuantidade.ClientID%>").value == "") {
                mensagem += "\n Produto Indisponivel no Estoque.";
                document.getElementById("<%=ddlQuantidade.ClientID%>").focus();

            }
            if (mensagem != null && mensagem != "") {
                alert(mensagem);
                return false;
            }

            return true;
        }
    </script>

</asp:Content>
