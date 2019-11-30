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
    public partial class actualiza_informacion : System.Web.UI.Page
    {
        usuario_BO objbo = new usuario_BO();
        usuario_DAO objdao = new usuario_DAO();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_usu"] == null)
            {
                Response.Redirect("Principal_informacion.aspx");

            }
            else
            {
                objbo.id_usu = Convert.ToInt32(Session["id_usu"]);
                objdao.busca_usuario(objbo);
                //carga datos a los texbox automaticamente
                lbl_id_usuario.Text = objbo.id_usu.ToString();
                txt_nuevo_nombre.Text = objbo.nom_usu;
                txt_nuevo_ape_pat.Text = objbo.ape_pat_usu;
                txt_apellido_materno_nuevo.Text = objbo.ape_mat_usu;
                txt_nuevo_correo.Text = objbo.correo_elec_usu;
                txt_contraseña.Text = objbo.contrasenia_usu;
                //txt_habilidades.Text = objbo.habilidades;
                txt_nikcname.Text = objbo.nickname;
                txt_fecha_naciemiento.Text = objbo.fecha_nac_usu.ToString();
                txt_telefono.Text = objbo.telefono_usu;
                txt_nikcname.Text = objbo.nickname;
            }
               
        }




        //limpiar controles
        protected void limpiarcontroles()
        {
            txt_nuevo_nombre.Text = "";
            txt_apellido_materno_nuevo.Text = "";
            txt_nuevo_ape_pat.Text = "";
            txt_nuevo_correo.Text = "";
            txt_contraseña.Text = "";
            txt_telefono.Text = "";
            txt_nikcname.Text = "";
            txt_habilidades.Text = "";
            txt_fecha_naciemiento.Text = "";

        }



        //metodo para llenar el bo
        protected void llenarbo()
        {
            objbo.id_usu =int.Parse (lbl_id_usuario.Text);
            objbo.nom_usu = txt_nuevo_nombre.Text;
            objbo.ape_pat_usu = txt_nuevo_ape_pat.Text;
            objbo.ape_mat_usu = txt_apellido_materno_nuevo.Text;
            objbo.correo_elec_usu = txt_nuevo_correo.Text;
            objbo.contrasenia_usu = txt_contraseña.Text;
            objbo.telefono_usu = txt_telefono.Text;
            objbo.habilidades = txt_habilidades.Text;
            objbo.nickname = txt_nikcname.Text;
            objbo.fecha_nac_usu=DateTime.Parse(txt_fecha_naciemiento.Text);

        }


        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarbo();
            //agrego el id al bo
            objbo.id_usu= int.Parse(lbl_id_usuario.Text);
            int valor = objdao.modificarusuario(objbo);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
    title: 'Alert!',
    content: 'Datos actualizados correctamente!',
});
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            //LimpiarControles();


          
        }
    }
}