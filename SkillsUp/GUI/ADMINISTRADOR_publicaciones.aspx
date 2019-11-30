<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/Dahsboard_administrador.Master" AutoEventWireup="true" CodeBehind="ADMINISTRADOR_publicaciones.aspx.cs" Inherits="SkillsUp.GUI.ADMINISTRADOR_publicaciones" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

    <%--<div class="row">--%>
        <%--<div class="col-md-3">--%>
            <%--para hacer espacio--%>
        <%--</div>--%>
    <div class="row">
<div class="col-md-4">

</div>
<div class="col-md-4">
    <asp:TextBox ID="txt_vacante" runat="server" CssClass="form-control"></asp:TextBox><br />
     <asp:TextBox ID="txt_habilidades" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:TextBox ID="txt_horario" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:TextBox ID="txt_sueldo" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:TextBox ID="txt_direccion" runat="server" CssClass="form-control"></asp:TextBox><br />



</div>
        <div class="col-md-4">

        </div>
    </div>

        <div >
            <%--data grid--%>

            <asp:GridView ID="gdv_publicaciones" runat="server" OnSelectedIndexChanged="gdv_publicaciones_SelectedIndexChanged" OnRowDataBound="gdv_publicaciones_RowDataBound"></asp:GridView>







        </div>


        <%--<div class="col-md-3">--%>
            <%--para hacer esapcio--%>
        <%--</div>--%>
   <%-- </div>--%>







</asp:Content>
