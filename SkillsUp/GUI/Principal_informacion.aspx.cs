using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SkillsUp.BO;
using SkillsUp.DAO;

namespace SkillsUp.GUI
{
    public partial class Principal_informacion : System.Web.UI.Page
    {
        usuario_BO objBO = new usuario_BO();
        usuario_DAO objDAO = new usuario_DAO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public void limpiarBO()
        //{
        //    txt_nombre.Text = "";
        //    txt_ape_paterno.Text = "";
        //    txt_ape_materno.Text = "";
        //    txt_correo.Text = "";
        //    txt_usuario_REG.Text = "";
        //    txt_contrasenia_REG.Text = "";
        //}



        //protected void llenarbo()
        //{

        //    objBO.nombre = txt_nombre.Text;//llena el campo del nombre de la pesona
        //    objBO.apellido_paterno = txt_ape_paterno.Text;//llena el campo de el apellido de la persona
        //    objBO.apellido_materno = txt_ape_materno.Text;//llena el campo del apellido materno de la persona
        //    objBO.correo_usuario = txt_correo.Text;//llena el campo del correo de la persona
        //    objBO.usuario = txt_usuario_REG.Text;//llena el campo de un nombre de usuario de la persona
        //    objBO.contrasenia = txt_contrasenia_REG.Text;//llean el campo de una contraseña para el usuario
        //}






        //        protected void btn_registrar_Click(object sender, EventArgs e)
        //        {
        //            //valida que todos los campos esten llenos 
        //           if(txt_nombre.Text==null|| txt_ape_paterno.Text==null|| txt_ape_materno.Text==null|| txt_correo.Text==null|| txt_usuario_REG.Text==null|| txt_contrasenia_REG.Text==null)
        //           {
        //                //activa un mensaje en caso de que los campos esten vacios
        //                string scriptjs = @"<script type='text/javascript'>
        //                            $.alert({
        //    title: 'Alert!',
        //    content: 'ALGUN CAMPO ESTA VACIO ERROR AL REGISTRAR!',
        //});
        //                        </script>";
        //                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
        //            }
        //           else//pero si todos los campos estan llenos guarda la informacion
        //            {
        //                llenarbo();
        //                //objBO.id_usuario = objDAO.agregarUsuario(objBO);

        //                int id = objDAO.agregarUsuario(objBO);

        //                string scriptjs = @"<script type='text/javascript'>
        //                            $.alert({
        //    title: 'Alert!',
        //    content: 'Datos agregados correctamente!',
        //});
        //                        </script>";
        //                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
        //                limpiarBO();
        //            }


        //        }

        protected void btn_iniciar_Click(object sender, EventArgs e)
        {
            //bootn para iniciar


            int id;
            int id_tipo;
            bool validado = false;

            id_tipo = 0;



            objBO.nickname = txt_usuario_IS.Text;
            objBO.contrasenia_usu = txt_contrasenia_IS.Text;





            id = objDAO.login(objBO);
            if (id != 0)
            {
                validado = true;
            }
            if (validado)
            {
                Session["id_usu"] = id;
              



            }
            id_tipo = objDAO.verificar_tipo(objBO);
            if (id_tipo == 1)
            {
                Response.Redirect("Index_User.aspx");
            }
            else
            {
                if (id_tipo == 2)
                {
                    Response.Redirect("index_admin.aspx");
                }
                else
                {
                    //DA UN MENSAJE DE ERROR POR SI LA CONTRASEÑA ESTA MAL ESCRITA

                    string scriptjs = @"<script type='text/javascript'>
                            $.alert({
    title: 'Alert!',
    content: 'ERROR AL INICIAR SESION ALGUN DATO INCORRETO!',
});
                        </script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);

                }
            }


















        }

        protected void lbtn_registro_Click(object sender, EventArgs e)
        {
            Response.Redirect("registro_de_usuarios.aspx");

        }

        protected void lbtn_recuperar_contraseña_Click(object sender, EventArgs e)
        {
            Response.Redirect("recuperar_contraseña.aspx");
        }
    }    
}