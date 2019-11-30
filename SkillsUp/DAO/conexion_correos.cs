using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Text;
using System.Data.SqlClient;
//using System.Data;


namespace SkillsUp.DAO
{
    public  abstract   class conexion_correos
    {
        private readonly string connectionString;
        SqlConnection conex;
        //creamos el contructor de la clase
       public conexion_correos()
        {
            connectionString = "Data source = LAPTOP-LA5MOK10; initial catalog = SkillsUp; integrated security = true";
           

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }



    }
}