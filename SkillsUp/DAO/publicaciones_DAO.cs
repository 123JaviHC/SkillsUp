using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkillsUp.BO;
using System.Data;
using SkillsUp.DAO;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SkillsUp.DAO
{
    public class publicaciones_DAO
    {

        conexion_DAO conex = new conexion_DAO();


        //para mostrar en el data grid view
        public DataSet buscar_publicacion()

        {

            DataSet datos = conex.ejecutaSentencia("select vacante,habilidades,horario,sueldo,direc_empresa  from Publicacion");

            return datos;

        }










    }
}