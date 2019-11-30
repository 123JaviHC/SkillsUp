using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SkillsUp.BO;
using SkillsUp.DAO;
using System.Web.SessionState;
namespace interfaz_usuario.MasterPage
{
    public partial class MP_usuario : System.Web.UI.MasterPage
    {
        usuario_BO objbo = new usuario_BO();
        usuario_DAO objdao = new usuario_DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
           //para que cargue el nombre del usuario y si no se inicia secion que lo redirija a la pagina 
           //principal

            if(Session["id_usu"]==null)
            {
                Response.Redirect("Principal_informacion.aspx");

            }
            else
            {
                objbo.id_usu = Convert.ToInt32(Session["id_usu"]);
                objdao.busca_usuario(objbo);
                //para que muestre el nombre del usuario en la aprte de arriba
                lbl_nombre_usuario.Text = objbo.nickname;
                string ruta = "~/Recursos/fotos_perfil/" + objbo.id_usu + objbo.foto_perfil;
                img_foto_perfil.ImageUrl = ruta;

            }




        }

        protected void imbtn_cerrar_Click(object sender, ImageClickEventArgs e)
        {
            Session["id_usu"] = null;

            if (Session["id_usu"] == null)
            {
                Response.Redirect("Principal_informacion.aspx");
            }
        }
    }
}