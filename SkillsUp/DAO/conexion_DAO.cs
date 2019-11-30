using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace SkillsUp.DAO
{
    public class conexion_DAO
    {
        SqlConnection conex;
        SqlDataAdapter adaptador;
        SqlCommand comandosql;
        DataSet datasetAdaptador;

        public SqlConnection conexion_BD()
        {
            //string con = "Data source = LAPTOP-LA5MOK10; initial catalog = BD_prueba1_SkillsUp; integrated security = true";            
            string con = "Data source = LAPTOP-LA5MOK10; initial catalog = SkillsUp; integrated security = true";
            conex = new SqlConnection(con);
            return conex;
        }

        public SqlConnection conexion_BD(string conexString)
        {
            string con = conexString;
            conex = new SqlConnection(con);
            return conex;
        }

        public void abrirConex()
        {
            conex.Open();
        }

        public void cerrarConex()
        {
            conex.Close();
        }

        public int ejecutaComando(string comando)
        {
            string strComandSQL = comando;
            adaptador = new SqlDataAdapter();
            comandosql = new SqlCommand();

            comandosql.Connection = this.conexion_BD();
            this.abrirConex();
            comandosql.CommandText = strComandSQL;

            int id = Convert.ToInt32(comandosql.ExecuteScalar());
            this.cerrarConex();

            return id;
        }

        public DataSet ejecutaSentencia(string sentencia)
        {
            comandosql = new SqlCommand();
            adaptador = new SqlDataAdapter();
            datasetAdaptador = new DataSet();

            string sqlcomando = sentencia;
            comandosql.CommandText = sqlcomando;

            comandosql.Connection = this.conexion_BD();
            this.abrirConex();

            adaptador.SelectCommand = comandosql;
            adaptador.Fill(datasetAdaptador);

            return datasetAdaptador;
        }







       















    }
}
