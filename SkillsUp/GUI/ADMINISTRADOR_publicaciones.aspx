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
      <!--comienza un div para  filas-->
<div class="row">

    <div class="col-md-1">
        <!---este div para hacer un espacio-->
    </div>
    <!--div para columnas-->
 
    <div class="col-md-4">
        <!--este div es para  controles-->
        <asp:Label ID="lbl_nombre" runat="server" Text="NOMBRE DE LA EMPRESA:"></asp:Label>
        <asp:TextBox ID="txt_nombre_empresa" runat="server" Cssclass=" form-control"  Enabled="false"></asp:TextBox>
            
           <asp:Label ID="lbl_correo" runat="server" Text="CORREO DE CONTACTO:"></asp:Label>
        <asp:TextBox ID="txt_correo" runat="server" Cssclass=" form-control" Enabled="false" ></asp:TextBox>
        


           <asp:Label ID="lbl_habilidades" runat="server" Text="HABIILIDADES:"></asp:Label>
        <asp:TextBox ID="txt_habilidades" runat="server" Cssclass=" form-control" Enabled="false" TextMode="MultiLine" ></asp:TextBox>
        

        
        
           <asp:Label ID="lbl_direccion" runat="server" Text="DIRECCION:"></asp:Label>
        <asp:TextBox ID="txt_direccion" runat="server" Cssclass=" form-control"  Enabled="false"></asp:TextBox>
        
        

        
           <asp:Label ID="lbl_contacto" runat="server" Text="PERSONA DE CONTACTO:"></asp:Label>
        <asp:TextBox ID="txt_contacto" runat="server" Cssclass=" form-control" Enabled="false"></asp:TextBox>
        
         <asp:Label ID="lbl_vacante" runat="server" Text="VACANTE:"></asp:Label>
        <asp:TextBox ID="txt_vacante" runat="server" Cssclass=" form-control" Enabled="false"></asp:TextBox>
        



         <asp:Label ID="lbl_salario" runat="server" Text="SALARIO:"></asp:Label>
        <asp:TextBox ID="txt_salario" runat="server" Cssclass=" form-control" Enabled="false"></asp:TextBox><br />
       
        <!--div para botones-->
        <div>
             <asp:Button ID="btn_autorizar" runat="server" Text="AUTORIZAR"  CssClass="btn_1" Height="40px"/>
              <asp:Button ID="btn_rechazar" runat="server" Text="RECHAZAR"  CssClass="btn_1" Height="40px"/>

        </div>
        <!--termina div de controles-->
    </div>
     <!--inicia div del data gridview-->
    <div class="col-md-7">


        <asp:GridView ID="dgv_publicaciones" runat="server"></asp:GridView><!--data de las publicaciones-->

        <!--finaliza div data gridview-->
    </div>
 
    
  <!--termina el div del row-->
</div>
   
    <br />
    <br />

           

</asp:Content>
