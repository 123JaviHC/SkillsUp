using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SkillsUp.GUI
{
    public partial class ADMINISTRADOR_USAURIOS_REGISTRADOS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //para seleccionar datos del gridview
        protected void dgv_usaurios_busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
           txt_id_usuario.Text = dgv_usaurios_busqueda.SelectedRow.Cells[0].Text;
           txt_nombre_usuario_buscar.Text = dgv_usaurios_busqueda.SelectedRow.Cells[1].Text;
           txt_ape_pat_usuario_buscar.Text = dgv_usaurios_busqueda.SelectedRow.Cells[2].Text;
           txt_apemat_usuario_buscar.Text = dgv_usaurios_busqueda.SelectedRow.Cells[3].Text;

            
        }
    }
}