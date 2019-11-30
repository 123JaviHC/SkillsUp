using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using SkillsUp.BO;
using SkillsUp.DAO;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace SkillsUp.GUI
{
    public partial class registro_de_usuarios1 : System.Web.UI.Page
    {
        usuario_BO objBO = new usuario_BO();
        usuario_DAO objDAO = new usuario_DAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void limpiarBO()
        {
            txt_nombre.Text = "";
            txt_ape_paterno.Text = "";
            txt_ape_materno.Text = "";
            txt_correo.Text = "";
            txt_usuario_REG.Text = "";
            txt_contrasenia_REG.Text = "";
            txt_fecha_nac.Text = "";
            txt_telefono.Text = "";
            txt_foto.Text = "";
        }



        protected void llenarbo()
        {

            objBO.nom_usu = txt_nombre.Text;//llena el campo del nombre de la pesona
            objBO.ape_pat_usu = txt_ape_paterno.Text;//llena el campo de el apellido de la persona
            objBO.ape_mat_usu = txt_ape_materno.Text;//llena el campo del apellido materno de la persona
            objBO.correo_elec_usu = txt_correo.Text;//llena el campo del correo de la persona
            objBO.nickname = txt_usuario_REG.Text;//llena el campo de un nombre de usuario de la persona
            objBO.contrasenia_usu = txt_contrasenia_REG.Text;//llean el campo de una contraseña para el usuario
            objBO.foto_perfil = txt_foto.Text;
            objBO.habilidades = "";

            objBO.telefono_usu = txt_telefono.Text;
            objBO.fecha_nac_usu = Convert.ToDateTime(txt_fecha_nac.Text);
            objBO.fk_estado_usu = 1;
            objBO.fk_gen_usu = 1;
            objBO.fk_pais_usu = 1;
            objBO.fk_tipo_usu = 1;
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            ////valida que todos los campos esten llenos
            //           if (txt_nombre.Text == null || txt_ape_paterno.Text == null || txt_ape_materno.Text == null || txt_correo.Text == null || txt_usuario_REG.Text == null || txt_contrasenia_REG.Text == null)
            //{
            //    //activa un mensaje en caso de que los campos esten vacios
            //    string scriptjs = @"<script type='text/javascript'>
            //                            $.alert({
            //    title: 'Alert!',
            //    content: 'ALGUN CAMPO ESTA VACIO ERROR AL REGISTRAR!',
            //});
            //                        </script>";
            //    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            //}
            //else//pero si todos los campos estan llenos guarda la informacion
            //{
            //    llenarbo();
            //    //objBO.id_usuario = objDAO.agregarUsuario(objBO);

            //    int id = objDAO.agregarUsuario(objBO);

            //    string scriptjs = @"<script type='text/javascript'>
            //                            $.alert({
            //    title: 'Alert!',
            //    content: 'Datos agregados correctamente!',
            //});
            //                        </script>";
            //    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            //    limpiarBO();
            //    Response.Redirect("Principal_informacion.aspx");

            //}
            //llena el BO 
            llenarbo();
            //objBO.id_usu = objDAO.agregarUsuario(objBO);
            //int id = objDAO.agregarUsuario(objBO);
            //SI EXISTE ARCHIVO EN EL CONTROL
            if (fu_selecciona.HasFile)
            {
                //validar extensiones aceptadas
                //OBTIENE LA EXTENSION DEL ARCHIVO
                String fileExtension = Path.GetExtension(fu_selecciona.FileName).ToLower();

                //ARREGLO TIPO STRING DE EXTENSIONES.
                String[] Exten_validas = { ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < Exten_validas.Length; i++)
                {
                    //si la extensión es alguna de las válidas
                    if (fileExtension == Exten_validas[i])
                    {
                        System.Drawing.Image ObjetoImagen;
                        string NombreArchivoPequenio = "_" + Path.GetFileName(fu_selecciona.PostedFile.FileName.Replace("_", ""));

                        objBO.foto_perfil = NombreArchivoPequenio;
                        //agrega a la base de datos
                        objBO.id_usu = objDAO.agregarUsuario(objBO);

                        string RutaImagenes = "~/Recursos/fotos_perfil/";
                        Bitmap ImagenEnBinario = new Bitmap(fu_selecciona.PostedFile.InputStream);
                        ObjetoImagen = objBO.RedimencionarImagen(ImagenEnBinario, 100);
                        switch (fileExtension)
                        {
                            case ".png":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objBO.id_usu + NombreArchivoPequenio, ImageFormat.Png);

                                break;
                            case ".jpg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objBO.id_usu + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                            case ".jpeg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objBO.id_usu + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                        }


                    }
                }

            }
            else
            {
                objBO.foto_perfil = "";
                objBO.id_usu= objDAO.agregarUsuario(objBO);
            }
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
    title: 'Alert!',
    content: 'Datos agregados correctamente!',
});
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            limpiarBO();
            Response.Redirect("Principal_informacion.aspx");














        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length <=10;
        }
    }
}