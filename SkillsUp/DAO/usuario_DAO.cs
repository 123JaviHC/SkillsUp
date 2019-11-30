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
    public class usuario_DAO:conexion_correos
    {
        conexion_DAO conex = new conexion_DAO();
        
        public int agregarUsuario(usuario_BO obj_usuarioBO)
        {
            //inserta y devuelve el ultimo el id insertado
            string sen = "INSERT INTO usuario (nom_usu,ape_pat_usu,ape_mat_usu,telefono_usu,fecha_nac_usu,correo_elec_usu,contrasenia_usu,foto_perfil,habilidades,nickname,fk_gen_usu,fk_estado_usu,fk_pais_usu,fk_tipo_usu) output INSERTED.id_usu values('" + obj_usuarioBO.nom_usu+ "','" + obj_usuarioBO.ape_pat_usu + "','" + obj_usuarioBO.ape_mat_usu+ "','" + obj_usuarioBO.telefono_usu+ "','" + obj_usuarioBO.fecha_nac_usu.ToString("yyyy-MM-dd") + "','" + obj_usuarioBO.correo_elec_usu+ "','" + obj_usuarioBO.contrasenia_usu+ "','" + obj_usuarioBO.foto_perfil+ "','" + obj_usuarioBO.habilidades + "','" + obj_usuarioBO.nickname+ "','" + obj_usuarioBO.fk_gen_usu + "','" + obj_usuarioBO.fk_estado_usu + "','" + obj_usuarioBO.fk_pais_usu + "','" + obj_usuarioBO.fk_tipo_usu+ "')";
            int id = conex.ejecutaComando(sen);

            return id;
            //int viri= conex.ejecutaComando("insert into usuario values('" + obj_usuarioBO.nom_usu + "','" + obj_usuarioBO.ape_pat_usu + "','" + obj_usuarioBO.ape_mat_usu + "','" + obj_usuarioBO.correo_elec_usu + "','" + obj_usuarioBO.nickname + "','" + obj_usuarioBO.contrasenia_usu+ "','" + obj_usuarioBO.telefono_usu+ ",'" + obj_usuarioBO.foto_perfil + "'','" + obj_usuarioBO.habilidades + "','" + obj_usuarioBO.fecha_nac_usu + "','" + obj_usuarioBO.fk_estado_usu + "','" + obj_usuarioBO.fk_gen_usu+ "','" + obj_usuarioBO.fk_pais_usu+ "','" + obj_usuarioBO.fk_tipo_usu+ "')");
            //return viri;
        }

        public int login(usuario_BO userBo)
        {
            DataSet datos = conex.ejecutaSentencia("select id_usu from usuario where nickname='" + userBo.nickname + "' and contrasenia_usu='" + userBo.contrasenia_usu + "'");

            int id = 0;

            if (datos.Tables[0].Rows.Count > 0)
            {
                id = Convert.ToInt32(datos.Tables[0].Rows[0]["id_usu"]);
            }
            return id;           
        }


        //verificar el tipo de usuario
        public int verificar_tipo(usuario_BO objbo)
        {
            DataSet datos = conex.ejecutaSentencia("select fk_tipo_usu from usuario where nickname='" + objbo.nickname + "'and contrasenia_usu='" + objbo.contrasenia_usu + "'");
            int fk_tipo_usu = 0;
            if (datos.Tables[0].Rows.Count > 0)
            {
                fk_tipo_usu = Convert.ToInt32(datos.Tables[0].Rows[0]["fk_tipo_usu"]);

            }
            return fk_tipo_usu;
        }













        public int modificarusuario(usuario_BO objusuario)
        {
            int id = conex.ejecutaComando(string.Format("update usuario set nom_usu='{0}',ape_pat_usu='{1}',ape_mat_usu='{2}',telefono_usu='{3}',fecha_nac_usu='{4}',correo_elec_usu='{5}',contrasenia_usu='{6}',foto_perfil='{7}',habilidades='{8}',nickname='{9}',fk_gen_usu='{10}',fk_estado_usu='{11}',fk_pais_usu='{12}',fk_tipo_usu='{13}' where id_usu={14}", objusuario.nom_usu, objusuario.ape_pat_usu, objusuario.ape_mat_usu, objusuario.telefono_usu, objusuario.fecha_nac_usu.ToString("yyyy-MM-dd"), objusuario.correo_elec_usu, objusuario.contrasenia_usu, objusuario.foto_perfil, objusuario.habilidades, objusuario.nickname,objusuario.fk_gen_usu,objusuario.fk_estado_usu,objusuario.fk_pais_usu,objusuario.fk_tipo_usu,objusuario.id_usu));
            return 1;
        }
        //metodo para verificar si el usuario existe
        //public bool exite (int valor )
        //{

        //}


        //ejecutar el buscar usuarios


        public void busca_usuario(usuario_BO objbo)
        {
            DataSet datos = conex.ejecutaSentencia("select * from usuario where id_usu=" + objbo.id_usu);
            objbo.nom_usu = datos.Tables[0].Rows[0]["nom_usu"].ToString();
            objbo.ape_pat_usu = datos.Tables[0].Rows[0]["ape_pat_usu"].ToString();
            objbo.ape_mat_usu= datos.Tables[0].Rows[0]["ape_mat_usu"].ToString();
            objbo.telefono_usu= datos.Tables[0].Rows[0]["telefono_usu"].ToString();
            objbo.fecha_nac_usu =DateTime.Parse(datos.Tables[0].Rows[0]["Fecha_nac_usu"].ToString());
            objbo.contrasenia_usu = datos.Tables[0].Rows[0]["contrasenia_usu"].ToString();
            objbo.correo_elec_usu= datos.Tables[0].Rows[0]["correo_elec_usu"].ToString();

            objbo.foto_perfil = datos.Tables[0].Rows[0]["foto_perfil"].ToString();
            objbo.habilidades = datos.Tables[0].Rows[0]["habilidades"].ToString();
            objbo.nickname= datos.Tables[0].Rows[0]["nickname"].ToString();

            objbo.fk_gen_usu = int.Parse(datos.Tables[0].Rows[0]["fk_gen_usu"].ToString());

            objbo.fk_estado_usu = int.Parse(datos.Tables[0].Rows[0]["fk_estado_usu"].ToString());
            objbo.fk_pais_usu = int.Parse(datos.Tables[0].Rows[0]["fk_pais_usu"].ToString());
            objbo.fk_tipo_usu = int.Parse(datos.Tables[0].Rows[0]["fk_tipo_usu"].ToString());



        }



        //recuperar la contraseña

        public string recuperarcontraseña(string userRequesting)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command=new SqlCommand())
                {
                    command.Connection = connection;
                    //solicitar todo donde usuario sea igual anickname y  o correo
                    command.CommandText = "select nickname,correo_elec_usu,contrasenia_usu from usuario where nickname=@user";

                    //asignamos valor al parametro para usuario
                    command.Parameters.AddWithValue("@user",userRequesting);
                    //asignamos valor al parametro para correo

                    //command.Parameters.AddWithValue("@correo",userRequesting);
                    command.CommandType = CommandType.Text;
                    //declaramos un lector de datos de sql
                    SqlDataReader reader = command.ExecuteReader();//hacemos qie lea los parametros qeu tiene el comand
                    //si la consulta existe optenemos los datos del usuario
                    if(reader.Read()==true)
                    {
                        //los numeroson las posiciones que ocupan en  las columnas los datos de sql como el nombre apellido etc.
                        //en sql comienza desde la columna 0 contando el id
                        string username = reader.GetString(0); //+ ", " + reader.GetString(2);
                        //obtenemos la posicion del correo del usuario y la contraseña
                        string usermail = reader.GetString(1);
                        string accountPassword = reader.GetString(2);
                        //instancioamos la clase correo soporte de sistema
                        var mailService = new SystemSupportMail();
                        //invocamos el metodo de enviar correo de la clase soporte de sistema
                        mailService.sendEmail(
                            subject:"SYSTEM: Password recovery request",
                            body:"Hi "+username+"\n you requested to recover your pasword.\n"+
                            "your current password is:"+accountPassword+
                            "\n However, we ask that you change your password inmediately once you enter the system attenttively soporte of Skillsup",
                            recipientmail:new List<string> { usermail}
                            );//requiere que le enviemos el asunto cuerpo y correo de destino

                        return "Hi " + username + "\n you requested to recover your pasword.\n" +
                            "your current password it was send  However, we ask that you change your password inmediately once you enter the system attenttively soporte of Skillsup";


                    }
                    else
                    {
                        //mensaje en caso de que no aya un correo con ese nombre 
                        return "sorry , you don't have a count with this email";
                    }
                    
                }








             




















            }







           



















        }

    }
}