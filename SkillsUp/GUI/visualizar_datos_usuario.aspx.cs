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
    public partial class visualizar_datos_usuario : System.Web.UI.Page
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
                //para que muestre el nombre del usuario en la aprte de arriba
                lbl_nombre_delusuario.Text = objbo.nom_usu;
                lbl_apellido_pat.Text = objbo.ape_pat_usu;
                lbl_apellido_materno.Text = objbo.ape_mat_usu;
                lbl_telefono.Text = objbo.telefono_usu;
                lbl_fehchanac.Text = objbo.fecha_nac_usu.ToString();
                lbl_correo.Text = objbo.correo_elec_usu;
                //si al traer las habilidades estan vacias muestra un mensaje por defecto
                if(objbo.habilidades=="")
                {
                    lbl_habilidades.Text = "DATOS POR LLENAR";
                }
                else
                {
                    //caso contrario manda lo que esta en la base de datos
                    lbl_habilidades.Text = objbo.habilidades;
                }


                 
                lbl_nickname.Text = objbo.nickname;

                //para la foto
                string ruta = "~/Recursos/fotos_perfil/" + objbo.id_usu + objbo.foto_perfil;
                img_avatar.ImageUrl = ruta;
                

            }



        }
    }
}