<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/registro.Master" AutoEventWireup="true" CodeBehind="recuperar_contraseña.aspx.cs" Inherits="SkillsUp.GUI.recuperar_contraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />


    <div class="card text-white bg-dark mb-3 mx-auto" style="max-width: 35rem;">
  <div class="card-header">recuperarcion de contraseña</div>
  <div class="card-body">
      <asp:Label ID="lbl_usuario" runat="server" Text="introduce tu nombre de usuario "></asp:Label>
      <asp:TextBox ID="txt_usuarionombre" runat="server" CssClass="form-control"></asp:TextBox><br />
     <asp:Label ID="lbl_mensaje" runat="server" Text="mensaje"></asp:Label><br />


      <asp:Button ID="btn_envia" runat="server" Text="Button" OnClick="btn_envia_Click" CssClass="btn_1" /><br />
      <asp:LinkButton ID="lbtn_pagina_principal" runat="server" OnClick="lbtn_pagina_principal_Click">ir a pagina principal</asp:LinkButton>

   
  </div>
</div>


</asp:Content>
