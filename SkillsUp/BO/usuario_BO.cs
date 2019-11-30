using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace SkillsUp.BO
{
    public class usuario_BO
    {

        public int id_usu { get; set; }//id de el usuario
        public string nom_usu { get; set; }//nombre del usuario
        public string ape_pat_usu { get; set; }//apellido paterno del usuario
        public string ape_mat_usu { get; set; }//apelido materno del usuario
        public string telefono_usu { get; set; }//telefono del usuario
        public DateTime fecha_nac_usu { get; set; }//fecha de nacimiento del usuario
        public string correo_elec_usu { get; set; }//correo electronico del usario
        public string contrasenia_usu { get; set; }//constrasenia del usuario
        public string foto_perfil { get; set; }//ruta del la foto del usuario
        public string habilidades { get; set; }//habilidades del usario
        public string nickname { get; set; }//nombre del usuario enla platafora
        public int fk_gen_usu { get; set; }//id del genero del usuario
        public int fk_estado_usu { get; set; }//id del estado del usuario
        public int fk_pais_usu { get; set; }//id del pasi del usuario
        public int fk_tipo_usu { get; set; }//id_del tipo de usuario




        //metodo para redimencionar imagen
        public Image RedimencionarImagen(Image Imgoriginal, int Altoimg)

        {

            var Radio = (double)Altoimg / Imgoriginal.Height;//diferencia entre la imagenes

            var NuevoAncho = (int)(Imgoriginal.Width * Radio);

            var NuevoAlto = (int)(Imgoriginal.Height * Radio);

            var ImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);

            //creo archivo apartir del bitmap con las nuevas dimensiones

            var g = Graphics.FromImage(ImagenRedimencionada);

            g.DrawImage(Imgoriginal, 0, 0, NuevoAncho, NuevoAlto);

            return ImagenRedimencionada;

        }


    }
}