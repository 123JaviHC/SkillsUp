<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MP_usuario.Master" AutoEventWireup="true" CodeBehind="actualiza_informacion.aspx.cs" Inherits="SkillsUp.GUI.actualiza_informacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" >
        <div class="col-md-3">

        </div>
<%--    form para actualizar datos--%>
    <div class="col-xs-6 col-sm-3 pricing-box " >
										<div class="widget-box widget-color-blue" aling-items: center y justify-content: center>
											<div class="widget-header">
												<h5 class="widget-title bigger lighter">Business Package</h5>
											</div>

											<div class="widget-body" aling-items: center y justify-content: center>
												<div class="widget-main" aling-items: center y justify-content: center>
													<ul class="list-unstyled spaced2">
														<li>
                                                           <%-- de este lbl_optengo el id que se esta actualizadndo--%>
                                                           <asp:Label ID="lbl_id_usuario" runat="server" Visible="False" ></asp:Label><br />

                                                            <asp:TextBox ID="txt_id_usuario" runat="server" CssClass="form-control" Visible="False"></asp:TextBox>
<%--                                                            nombre--%>
                                                            <asp:Label ID="lbl_nuevo_nombre" runat="server" Text="nombre"></asp:Label>
                                                            <asp:TextBox ID="txt_nuevo_nombre" runat="server" CssClass="form-control"></asp:TextBox>
<%--                                                            apellido paterno--%>
                                                            <asp:Label ID="lbl_nuevo_ape_pat" runat="server" Text="apellido paterno"></asp:Label>
                                                            <asp:TextBox ID="txt_nuevo_ape_pat" runat="server" CssClass="form-control"></asp:TextBox>
<%--                                                            apellido materno--%>
                                                            <asp:Label ID="lbl_nuevo_ape_mat" runat="server" Text="apellido materno"></asp:Label>
                                                            <asp:TextBox ID="txt_apellido_materno_nuevo" runat="server" CssClass="form-control"></asp:TextBox>


                                                               <%--fecha de nacimiento--%>
                                                            <asp:Label ID="lbl_fecha_nacimiento" runat="server" Text="fecha de namcimiento"></asp:Label>
                                                            <asp:TextBox ID="txt_fecha_naciemiento" runat="server" placeHolder="año-mes-dia" CssClass="form-control"></asp:TextBox>


<%--                                                            correo electronico--%>
                                                            <asp:Label ID="lbl_correo_nuevo" runat="server" Text="correo electronico"></asp:Label>
                                                            <asp:TextBox ID="txt_nuevo_correo" runat="server" CssClass="form-control"></asp:TextBox>
<%--                                                            contraseña--%>
                                                            <asp:Label ID="lbl_contraseña" runat="server" Text="contraseña"></asp:Label>
                                                            <asp:TextBox ID="txt_contraseña" runat="server" CssClass="form-control"></asp:TextBox>
<%--                                                            telefono--%>
                                                            <asp:Label ID="lbl_telefono" runat="server" Text="telefono"></asp:Label>
                                                            <asp:TextBox ID="txt_telefono" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>

                                                                   <%--editar habilidades--%>
                                                            <asp:Label ID="lbl_habilidades" runat="server" Text="habilidades"></asp:Label>
                                                            <asp:TextBox ID="txt_habilidades" runat="server" CssClass="form-control" TextMode="MultiLine" MaxLength="100"></asp:TextBox>

                                                            <%--nickname--%>
                                                            <asp:Label ID="lbl_nickname" runat="server" Text="nickname"></asp:Label>
                                                            <asp:TextBox ID="txt_nikcname" runat="server" CssClass="form-control"></asp:TextBox>
                                                            
														</li>

														
											</ul>

												<div>
                                                    <asp:Button ID="btn_actualizar" runat="server" Text="actualizar" CssClass="btn btn-block btn-primary" OnClick="btn_actualizar_Click" />		
												</div>
											</div>
										</div>
									</div>

        </div>
        
    

<%--    filnaliza form para actualizar datos--%>

    <br />
    <br />
    <br />
    <br />


        </div>

</asp:Content>
