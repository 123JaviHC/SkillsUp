using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillsUp.BO
{
    public class publicaciones_BO
    {
        public int id_publicacion { set; get; } //id de las publicaciones 
        public string fecha_solicitud { set; get; }

        public string nom_empresa { set; get; }
        public string correo_cotacto { set; get; }
        public string habilidades { set; get; }
        public string estado { set; get; }
        public string ciudad { set; get; }
        public string telefono { set; get; }
        public string direccion { set; get; }
        public string persona_contacto { set; get; }
        public string vacante { set; get; }
        public string carrera { set; get; }
        public string genero { set; get; }
        public string edad { set; get; }
        public string estado_civil { set; get; }
        public string funciones { set; get; }
        public string experiencia { set; get; }
        public string tipo_jornada { set; get; }
        public string horario { get; set; }
        public string salario { get; set; }
        public string prestaciones { get; set; }

        public string fk_estatus { set; get; }










    }
}