<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DefaultMaster.Master" CodeBehind="Inicio.aspx.cs" Inherits="DEV.WEB.Inicio" %>

<asp:Content runat="server" ContentPlaceHolderID="Masterhead">
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentMain">
   <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
        <%--indicado colocar imagem 800x200 px--%>
      <img class="d-block w-100" src="content/img/Carrosel.svg" alt="First slide">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src="content/img/Carrosel.svg" alt="Second slide">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src="content/img/Carrosel.svg" alt="Third slide">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="ContentEnd">
</asp:Content>
