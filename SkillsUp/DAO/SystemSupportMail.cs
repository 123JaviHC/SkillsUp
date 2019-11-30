using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkillsUp.DAO;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace SkillsUp.DAO
{
    //clase soporte para systema de emails
    class SystemSupportMail:servicio_email_DAO//heredamos de los servicios del email
    {

        public SystemSupportMail()
        {
            //escribimos el nombre del correo que envia los mensajes
            SendereMail = "soporteskillsup@gmail.com";
            //escribimos la contraseña del correo
            password = "abcskillsup";
            //host de gmail aca depende del correo 
            host = "smtp.gmail.com";
            //puerto este igual depende del servidor del email este caso es el de gmail
            port = 587;
            //tipo de cifrado del servidor en este caso gmail sui es ssl asi que lo ponemos en true
            ssl = true;
            //inicializamos el metodo smtp
            initializeSmtpClient();
        }


    }
}