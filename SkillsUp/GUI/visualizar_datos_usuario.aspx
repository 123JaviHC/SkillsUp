<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MP_usuario.Master" AutoEventWireup="true" CodeBehind="visualizar_datos_usuario.aspx.cs" Inherits="SkillsUp.GUI.visualizar_datos_usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />

    <div class="user-profile row">
    <!--muestra imagen-->
    <span class="profile-picture">
   <asp:Image ID="img_avatar" runat="server" class="editable img-responsive" />
    </span>











<%--    card de la informacion personal--%>
  <div class="profile-user-info profile-user-info-striped">
                                                  <!--muestra nombre-->
												<div class="profile-info-row">
													<div class="profile-info-name"> NOMBRE  </div>

													<div class="profile-info-value">
                                               <asp:Label ID="lbl_nombre_delusuario" runat="server" Text="Label"></asp:Label>

													</div>
												</div>
                                                 <!--finaliza muestra nombre-->

                                               <!--muestra apellido paterno-->
												<div class="profile-info-row">
													<div class="profile-info-name"> APELLIDOS </div>

													<div class="profile-info-value">
                                               <asp:Label ID="lbl_apellido_pat" runat="server" Text="Label"></asp:Label>
                                               <asp:Label ID="lbl_apellido_materno" runat="server" Text="Label"></asp:Label>


													</div>
												</div>
                                                 <!--finaliza muestra apellido-->


                                              

                                                  <!--muestra telefono-->
												<div class="profile-info-row">
													<div class="profile-info-name">TELEFONO</div>

													<div class="profile-info-value">
                                               <asp:Label ID="lbl_telefono" runat="server" Text="Label"></asp:Label>


													</div>
												</div>
                                                 <!--finaliza muestra telefono-->


      
                                                  <!--muestra fecha nacimiento-->
												<div class="profile-info-row">
													<div class="profile-info-name">FECHA DE NACIMIENTO</div>

													<div class="profile-info-value">
                                               <asp:Label ID="lbl_fehchanac" runat="server" Text="Label"></asp:Label>


													</div>
												</div>
                                                 <!--finaliza muestra fecha nacimiento-->

                                                   <!--muestra coreo electronico-->
												<div class="profile-info-row">
													<div class="profile-info-name">CORREO ELECTRONICO</div>

													<div class="profile-info-value">
                                               <asp:Label ID="lbl_correo" runat="server" Text="Label"></asp:Label>


													</div>
												</div>
                                                 <!--finaliza muestra correo electronico-->

                                                  <!--muestra habilidades-->
												<div class="profile-info-row">
													<div class="profile-info-name">HABILIDADES</div>

													<div class="profile-info-value">
                                               <asp:Label ID="lbl_habilidades" runat="server" Text="Label"></asp:Label>


													</div>
												</div>
                                                 <!--finaliza muestra habilidades-->

                                                 <!--muestra nickname-->
												<div class="profile-info-row">
													<div class="profile-info-name">NICKNAME</div>

													<div class="profile-info-value">
                                               <asp:Label ID="lbl_nickname" runat="server" Text="Label"></asp:Label>


													</div>
												</div>
                                                 <!--finaliza muestra nickname-->


	</div>
</div>
</asp:Content>
