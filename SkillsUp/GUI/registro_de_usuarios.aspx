<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/registro.Master" AutoEventWireup="true" CodeBehind="registro_de_usuarios.aspx.cs" Inherits="SkillsUp.GUI.registro_de_usuarios1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <script>

        function cambia_nombre() {

            var fileName = $("#<%=fu_selecciona.ClientID%>").val();
            $("#<%=fu_selecciona.ClientID%>").next('.custom-file-label').html

                (fileName);



        }
    </script>

  
   


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="card text-white bg-dark mb-3 mx-auto " style="max-width: 32rem;">
        <div class="card-header ">REGISTRO DE USUARIOS</div>
        <div class="card-body">


            <asp:TextBox ID="txt_id_usuario_REG" Visible="false" runat="server"></asp:TextBox>
            <asp:TextBox ID="txt_foto" visible="false"      runat="server"></asp:TextBox>


            <asp:Label ID="lbl_nombre" runat="server" Text="Nombre"></asp:Label><br />
            <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validador_nombre" runat="server" ControlToValidate="txt_nombre" ErrorMessage="*este campo no puede estar vacio!!!." ForeColor="Red"> </asp:RequiredFieldValidator><br />



            <asp:Label ID="lbl_apellido_paterno" runat="server" Text="Apellido paterno"></asp:Label><br />
            <asp:TextBox ID="txt_ape_paterno" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validador_apellido_pat" runat="server" ControlToValidate="txt_ape_paterno" ErrorMessage="*este campo no puede estar vacio!!!" ForeColor="Red"> </asp:RequiredFieldValidator><br />





            <asp:Label ID="lbl_apellido_materno" runat="server" Text="Apellido materno"></asp:Label><br />
            <asp:TextBox ID="txt_ape_materno" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validador_ape_materno" runat="server" ControlToValidate="txt_ape_materno" ErrorMessage="*este campo no puede estar vacio!!!" ForeColor="Red"> </asp:RequiredFieldValidator><br />



            <asp:Label ID="lbl_correo_electronico" runat="server" Text="Correo electrónico"></asp:Label><br />
            <asp:TextBox ID="txt_correo" runat="server" placeholder="Ej. juanperez@ejemplo.com" TextMode="Email" CssClass="form-control"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="validador_correo" runat="server" ControlToValidate="txt_correo" ErrorMessage="*este campo no puede estar vacio!!!" ForeColor="Red"> </asp:RequiredFieldValidator><br />
<%--            valida correos reales--%>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="ingrese un email valido" ControlToValidate="txt_correo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Yellow"></asp:RegularExpressionValidator><br />

            

             <asp:Label ID="lbl_telefono" runat="server" Text="telefono"></asp:Label><br />
            <asp:TextBox ID="txt_telefono" runat="server" CssClass="form-control" placeHolder="escribir sin espacios ni guiones" MaxLength="10"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_telefono" ErrorMessage="*este campo no puede estar vacio!!!" ForeColor="Red"> </asp:RequiredFieldValidator><br />
<%--            valida maximo de caracteres--%>
           <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="ocupar 10 caracteres solamente" ControlToValidate="txt_telefono" OnServerValidate="CustomValidator1_ServerValidate" ForeColor="Yellow"></asp:CustomValidator><br />




            
             <asp:Label ID="lbl_validador_fecha_nac" runat="server" Text="telefono"></asp:Label><br />
            <asp:TextBox ID="txt_fecha_nac" runat="server" CssClass="form-control" placeHolder="año-mes-dia"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_fecha_nac" ErrorMessage="*este campo no puede estar vacio!!!" ForeColor="Red"> </asp:RequiredFieldValidator><br />




            <asp:Label ID="lbl_nombre_usuario" runat="server" Text="Nombre de usuario"></asp:Label><br />
            <asp:TextBox ID="txt_usuario_REG" runat="server" CssClass="form-control"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="validador_nombre_de_usuario" runat="server" ControlToValidate="txt_usuario_REG" ErrorMessage="*este campo no puede estar vacio!!!" ForeColor="Red"> </asp:RequiredFieldValidator><br />



            <asp:Label ID="lbl_contraseña" runat="server" Text="Contraseña"></asp:Label><br />
            <asp:TextBox ID="txt_contrasenia_REG" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="validador_contrasenia" runat="server" ControlToValidate="txt_contrasenia_REG" ErrorMessage="*este campo no puede estar vacio!!!" ForeColor="Red"> </asp:RequiredFieldValidator><br />


             <div class="custom-file">
                <asp:FileUpload ID="fu_selecciona" runat="server"  text="selecciona" CssClass="custom-file-input"    onchange="javascript:cambia_nombre()" />
                <asp:Label ID="lbl_selecciona" runat="server" Text="selecciona"   CssClass="custom-file-label"  ></asp:Label><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="fu_selecciona" ErrorMessage="*este campo no puede estar vacio!!!" ForeColor="Red"> </asp:RequiredFieldValidator><br />


            </div><br /><br />
            

            <asp:Button ID="btn_registrar" runat="server" Text="Registrar" CssClass="btn_1" Style="padding-right: 200px; padding-left: 200px; padding-bottom: 30px; padding-top: 10px; font-size: 16px;"  OnClick="btn_registrar_Click" />
        </div>
    </div>

</asp:Content>
