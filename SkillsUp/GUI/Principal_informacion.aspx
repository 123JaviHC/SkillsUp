<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/index_login.Master" AutoEventWireup="true" CodeBehind="Principal_informacion.aspx.cs" Inherits="SkillsUp.GUI.Principal_informacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <%--     <script>
        function validar_form() {
            //declaro variable boleano con valor en false 
            validado = false;
            //pregunto si txtbase esta vacio
            if ($("#<%=txt_contrasenia_IS.ClientID%>" || "#<%=txt_usuario_IS.ClientID%>" ).val().length <= 0) {

                $.alert({

                    title: '¡atencion!',
                    type: 'orange',
                    content: 'la radio no puede estar vacia',

                })

            } else {
                validado = true;
            }

         
            return validado;

        }

   </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="banner_part">        
        <a name="AcercaDe">
            <div class="container">
                <div class="row align-items-center">
                    <div class="col-lg-6 col-xl-6">
                        <div class="banner_text">
                            <div class="banner_text_iner">
                                <h5>Acerca de nosotros</h5>
                                <h1>Se reconocido por tus habilidades</h1>
                                <p>
                                    La aplicacion te beneficiará en encontrar tu nuevo empleo, es una nueva oportunidad,
                                    se reconocido por tus habilidades.
                                </p>
                                <a href="registro_de_usuarios.aspx" class="btn_1">No tengo cuenta, Registrarme</a>
                                <a href="#" class="btn_2" data-toggle="modal" data-target="#exampleModalCenter">Iniciar sesión </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <img src="../Recursos/IMAGENES/habilidades.png" alt="foto" />
                    </div>
                </div>
            </div>
        </a>
        <%--MODAL--%>
        <div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalCenterTitle">Iniciar Sesión</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <%--NAV--%>
                        <nav>
                            <div class="nav nav-tabs" id="nav-tab" role="tablist">
                                <a class="nav-item nav-link active" id="nav-home-tab" data-toggle="tab" href="#nav-home" role="tab" aria-controls="nav-home" aria-selected="true">Iniciar sesión</a>
                                <a class="nav-item nav-link" id="nav-contact-tab" data-toggle="tab" href="#nav-contact" role="tab" aria-controls="nav-contact" aria-selected="false">Registrarse</a>
                            </div>
                        </nav>
                        <div class="tab-content" id="nav-tabContent">
                            <%--MODAL INICIAR SESION--%>
                            <div class="tab-pane fade show active" id="nav-home" role="tabpanel" aria-labelledby="nav-home-tab">
                                <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label><br />
                                <asp:TextBox ID="txt_usuario_IS" runat="server" CssClass="form-control" placeHolder="Nombre de usuario"></asp:TextBox><br />
<%--                                <asp:RequiredFieldValidator ID="rfv_txt_usuario" runat="server" ErrorMessage="ingrese el nombre de usuario porfavor" Display="Dynamic" ControlToValidate="txt_usuario_IS" Text="*"></asp:RequiredFieldValidator>--%>
                                <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label><br />
                                <asp:TextBox ID="txt_contrasenia_IS" runat="server" CssClass="form-control" placeHolder="Contraseña" TextMode="Password"></asp:TextBox><br />
<%--                                <asp:RequiredFieldValidator ID="rfv_txt_contraseña" runat="server" ErrorMessage="ingrese la contraseña porfavor" Display="Dynamic" ControlToValidate="txt_contrasenia_IS"></asp:RequiredFieldValidator>--%>

                                <center><asp:Button ID="btn_iniciar" runat="server" Text="Iniciar sesión" CssClass="btn_1" style="padding-right:180px; padding-left:180px; padding-bottom:30px; padding-top:10px; font-size:16px;" OnClick="btn_iniciar_Click" CausesValidation="True"/></center><br />
                                <asp:LinkButton ID="lbtn_recuperar_contraseña" runat="server" OnClick="lbtn_recuperar_contraseña_Click">recuperar contraseña</asp:LinkButton>


                            </div>
                            <%--MODAL REGISTRARSE--%>
                            <div class="tab-pane fade" id="nav-contact" role="tabpanel" aria-labelledby="nav-contact-tab">
                              <asp:LinkButton ID="lbtn_registro" runat="server" OnClick="lbtn_registro_Click">PARA REGISTRARTE DARLE CLICK A ESTA LIGA</asp:LinkButton>  <%--<center><button type="button" class="btn_1" data-dismiss="modal" style="padding-right:190px; padding-left:190px; font-size:16px;">Registrarse</button></center>--%>
                            </div>
                            <%--FIN NAV--%>
                            <%--</div>
                    
               
                </div>--%>
                        </div>
                    </div>
                    <%--FIN MODAL--%>
    </section>

    <!-- banner part start-->


    <!-- feature_part start-->
    <a name="aprende">
        <section class="feature_part">

            <div class="container">
                <div class="row">
                    <div class="col-sm-6 col-xl-3 align-self-center">
                        <div class="single_feature_text ">
                            <h2>Esta es la manera como trabajamos</h2>
                            <p>
   Solo registrate y compartenos tus habilidades, constante recibiras notificaciones de nuestra ofertas de trabajos y cursos.
                            </p>
                            <%-- <a href="#" class="btn_1">Read More</a>--%>
                        </div>
                    </div>
                    <div class="col-sm-6 col-xl-3">
                        <div class="single_feature">
                            <div class="single_feature_part">
                                <img src="../Recursos/IMAGENES/llenadatos.jpg" />
                                <h4>Llena el perfil con tu información</h4>
                                <p>
                                                             
       Tus habilidades quedaran guardades y toda tu información estará segura y protegida, tus habilidades y ciertos datos serán visibles por empresas.
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6 col-xl-3">
                        <div class="single_feature">
                            <div class="single_feature_part">
                                <img src="../Recursos/IMAGENES/aprendiendo.jpg" />
                                <h4>Conoce las ofertas</h4>
                                <p>
                                    Tenemos grandes cantidades de cursos en la cual podras capasitarte y lograr nuevas hablidades que podras aplicar en tus estadías en el sector empresarial.
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6 col-xl-3">
                        <div class="single_feature">
                            <div class="single_feature_part single_feature_part_2">
                                <img src="../Recursos/IMAGENES/capacita.jpg" />
                                <h4>Capasitate con nosotros</h4>
                                <p>
                                    Constantemente te llegaran cursos en línea en la cual reforzaras tus conocimientos que te aydaran a adentrarte al mundo laboral.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </section>
    </a>
    <!-- upcoming_event part start-->




    <!--::review_part start::-->
    <a name="comunidad">
        <section class="special_cource padding_top">
            <div class="container">
                <div class="row">
                    <div class="col-sm-6 col-lg-4">
                        <div class="single_special_cource">
                            <img src="../Recursos/IMAGENES/llenadatos.jpg" class="special_img" alt="saas" />
                            <%--<img src="img/special_cource_1.png" class="special_img" alt="">--%>
                            <div class="special_cource_text">
                                <a class="btn_4">Estudiantes</a>

                                <h3>Universitarios </h3>

                                <p>Quienes estan cursando los últimos cuatrimestres de su carrera y estan a punto de ingresar a una empresa para realizar estadias.</p>
                                <div class="author_info">
                                    <%--<div class="author_img">
                                                <img src="img/author/author_1.png" alt="">
                                                <div class="author_info_text">
                                                    <p>Conduct by:</p>
                                                    <h5><a href="#">James Well</a></h5>
                                                </div>
                                            </div>--%>
                                    <div class="author_rating">
                                        <div class="rating">
                                            <a href="#">
                                                <img src="img/icon/color_star.svg" alt=""></a>
                                            <a href="#">
                                                <img src="img/icon/color_star.svg" alt=""></a>
                                            <a href="#">
                                                <img src="img/icon/color_star.svg" alt=""></a>
                                            <a href="#">
                                                <img src="img/icon/color_star.svg" alt=""></a>
                                            <a href="#">
                                                <img src="img/icon/star.svg" alt=""></a>
                                        </div>

                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-sm-6 col-lg-4">
                        <div class="single_special_cource">
                            <img src="../Recursos/IMAGENES/habiladaencontrada.png" class="special_img" alt="" />
                            <div class="special_cource_text">
                                <a class="btn_4">Empresas</a>

                                <h3>Empresas e instituciones</h3>

                                <p>Las empresas solicitaran sus vacantes en el sitio con especificaciones y requisitos que buscan en estudiantes.</p>
                                <div class="author_info">
                                </div>
                                <div class="author_rating">
                                    <div class="rating">
                                        <a href="#">
                                            <img src="img/icon/color_star.svg" alt=""></a>
                                        <a href="#">
                                            <img src="img/icon/color_star.svg" alt=""></a>
                                        <a href="#">
                                            <img src="img/icon/color_star.svg" alt=""></a>
                                        <a href="#">
                                            <img src="img/icon/color_star.svg" alt=""></a>
                                        <a href="#">
                                            <img src="img/icon/star.svg" alt=""></a>
                                    </div>

                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-sm-6 col-lg-4">
                        <div class="single_special_cource">
                            <img src="../Recursos/IMAGENES/capacita.jpg" class="special_img" alt="" />
                            <div class="special_cource_text">
                                <a class="btn_4">Mas personas</a>

                                <h3>Extras</h3>

                                <p>Registrate, tienes habilidades tu peedes entrar a donde sea, ya te dije que te registres nose porque sigues leyendo. Bueno ya anda a registrarte.</p>
                                <div class="author_info">
                                    <div class="author_img">
                                    </div>
                                    <div class="author_rating">
                                        <div class="rating">
                                            <a href="#">
                                                <img src="img/icon/color_star.svg" alt=""></a>
                                            <a href="#">
                                                <img src="img/icon/color_star.svg" alt=""></a>
                                            <a href="#">
                                                <img src="img/icon/color_star.svg" alt=""></a>
                                            <a href="#">
                                                <img src="img/icon/color_star.svg" alt=""></a>
                                            <a href="#">
                                                <img src="img/icon/star.svg" alt=""></a>
                                        </div>

                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </section>
    </a>
    <!--::blog_part end::-->

    <!-- learning part start-->
    <a name="somos">
        <section class="advance_feature learning_part">
            <div class="container">
                <div class="row align-items-sm-center align-items-xl-stretch">
                    <div class="col-md-6">
                        <div class="learning_member_text">
                            <h5>¿Quiénes somos?
                            </h5>
                            <h2>SkillsUp</h2>
                            <p>
                                Somos una página creada por alumnos de la UTM, en beneficio de la comunidad estudiantil de mencionada universidad, contaran con grandes recursos para poder capacitarse y lograr objetivos.
                            </p>
                        </div>
                        <div class="learning_member_text">
                            <h5>Te ofrecemos:
                            </h5>
                        </div>
                        <div class="learning_member_text_iner">

                            <img src="../Recursos/IMAGENES/cursos.png" />
                            <h4>Cursos en línea</h4>
                            <p>Haste una persona sobresaliente a través de los cursos recomendados para ti.</p>
                        </div>

                        <div class="learning_member_text_iner">

                            <img src="../Recursos/IMAGENES/laboral.png" />
                            <h4>Campo laboral</h4>
                            <p>Gracias a estas capacitaciones lograrás cubrir con distintos aspectos que una empresa busca en ti.</p>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <img src="../Recursos/IMAGENES/edificioutm.jpg" />
                    </div>

                    <div class="row">
                        <div class=" col-md-6">
                        </div>
                    </div>
                    <div class="col-md-6">
                    </div>

                </div>
            </div>
        </section>
    </a>
    <!-- learning part end-->

</asp:Content>
