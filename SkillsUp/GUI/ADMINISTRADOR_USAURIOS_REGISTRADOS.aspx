<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/Dahsboard_administrador.Master" AutoEventWireup="true" CodeBehind="ADMINISTRADOR_USAURIOS_REGISTRADOS.aspx.cs" Inherits="SkillsUp.GUI.ADMINISTRADOR_USAURIOS_REGISTRADOS" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
<%--    division para los txbox y otros controles--%>
    <div  class="row"  >
        <div class="col-md-1">
<%--            para que no este tanpegado a la izquierda los controles--%>
        </div>

<div class="col-md-2" >
        <asp:TextBox ID="txt_id_usuario" runat="server" CssClass="form-control" Enabled="False" Visible="False"></asp:TextBox><br />

        <asp:Label ID="lbl_nombre" runat="server" Text="nombre del usuario:"></asp:Label><br />
        <asp:TextBox ID="txt_nombre_usuario_buscar" runat="server" CssClass="form-control"></asp:TextBox><br />

            <asp:Label ID="lbl_epellido_paterno" runat="server" Text="apellido paterno del usuario:"></asp:Label><br />
        <asp:TextBox ID="txt_ape_pat_usuario_buscar" runat="server" CssClass="form-control"></asp:TextBox><br />

            <asp:Label ID="lbl_ape_mat" runat="server" Text="apellido materno del usuario:"></asp:Label><br />
        <asp:TextBox ID="txt_apemat_usuario_buscar" runat="server" CssClass="form-control"></asp:TextBox><br />

            <asp:Label ID="lbl_telefono" runat="server" Text="telefono del usuario:"></asp:Label><br />
        <asp:TextBox ID="txt_telefono" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox><br />

  



</div>
        <br />
        <br />
<%--    division para el data grid view--%>
    <div class="col-md-2">
        <br />
          <asp:Label ID="lbl_correo" runat="server" Text="correo electronico:"></asp:Label><br />
        <asp:TextBox ID="txt_correo" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox><br />



     <asp:Label ID="lbl_nickname" runat="server" Text="nickname:"></asp:Label><br />
        <asp:TextBox ID="txt_nickname" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox><br />




    <asp:Button ID="Button1" runat="server" Text="BUSCAR USUARIOS" CssClass="btn_1"  Height="40px"/>
    </div>
<%--        div para e3l data grid view--%>
        <div class="col-md-7">

        <asp:GridView ID="dgv_usaurios_busqueda" runat="server" OnSelectedIndexChanged="dgv_usaurios_busqueda_SelectedIndexChanged"></asp:GridView>


        </div>


        </div>




</asp:Content>
