<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MP_usuario.Master" AutoEventWireup="true" CodeBehind="Index_User.aspx.cs" Inherits="SkillsUp.GUI.Index_User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Este es el panel del usuario: Bienvenido</h1>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
