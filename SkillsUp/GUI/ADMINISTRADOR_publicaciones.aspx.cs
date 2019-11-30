using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SkillsUp.BO;
using System.Data;
using SkillsUp.DAO;
using System.Data.SqlClient;
using System.Threading.Tasks;



namespace SkillsUp.GUI
{
    public partial class ADMINISTRADOR_publicaciones : System.Web.UI.Page
    {
        publicaciones_BO objbo = new publicaciones_BO();
        publicaciones_DAO objdao = new publicaciones_DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            gdv_publicaciones.DataSource = objdao.buscar_publicacion();
            gdv_publicaciones.DataBind();

        }

        protected void gdv_publicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_vacante.Text = gdv_publicaciones.SelectedRow.Cells[0].Text;
            txt_habilidades.Text = gdv_publicaciones.SelectedRow.Cells[1].Text;
            txt_horario.Text = gdv_publicaciones.SelectedRow.Cells[2].Text;
            txt_sueldo.Text = gdv_publicaciones.SelectedRow.Cells[3].Text;
            txt_direccion.Text = gdv_publicaciones.SelectedRow.Cells[4].Text;
        }





       

        protected void gdv_publicaciones_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gdv_publicaciones, "select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";

            }

        }
    }
}