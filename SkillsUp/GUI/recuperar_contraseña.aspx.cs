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
    public partial class recuperar_contraseña : System.Web.UI.Page
    {
        usuario_DAO objdao = new usuario_DAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string recoverpassword(string userREquesting)
        {
            return objdao.recuperarcontraseña(userREquesting);
        }



        protected void btn_envia_Click(object sender, EventArgs e)
        {
            //instanciamos la clase oa que es donde tenemos el metodo para recuperar contraseña
            var user = new usuario_DAO();
            //mandamos los parametros
            var result = user.recuperarcontraseña(txt_usuarionombre.Text);
            //mandamos el mensaje
            lbl_mensaje.Text = result;

        }

        protected void lbtn_pagina_principal_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal_informacion.aspx");
        }
    }
}