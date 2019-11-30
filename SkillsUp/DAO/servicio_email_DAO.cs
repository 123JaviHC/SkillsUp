using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace SkillsUp.DAO
{
    public abstract class servicio_email_DAO
    {
        private SmtpClient smtpClient;

        protected string SendereMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }



        protected void  initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            //envia el corroe del remitente y su contraseña
            smtpClient.Credentials = new NetworkCredential(SendereMail,password);
            //el host 
            smtpClient.Host = host;
            //el puerto 
            smtpClient.Port = port;
            //el cifrado
            smtpClient.EnableSsl = ssl;



        }

        //metodo publico para enviar los mensajes de correo

            //como parametros enviamos el asunto del correo y el cuarpo del correo
            //el list strig es para enviar a varios correos electronicos 
        public void sendEmail(string subject,string body,List<string> recipientmail)
        {
            //instanciamos a la clase mennsaje de correo
            var mailMessaje = new MailMessage();
            //creamos un trycatch
            try
            {
                //enviamos el mensaje 
                mailMessaje.From = new MailAddress(SendereMail);
                foreach (string mail in recipientmail)
                {
                    //indicamos par quien sera enviado el mensaje
                    //enviamos las direcciones de correo de la lista recipientmail
                    mailMessaje.To.Add(mail);
                }
                mailMessaje.Subject = subject;//especificamso el asunto del correo con el parametro asunto
                mailMessaje.Body = body;//especificacos el cuerpo con el parametro body
                mailMessaje.Priority = MailPriority.Normal;//asignamos prioridad al amensaje
                //enviamos el mensaje
                smtpClient.Send(mailMessaje);

            }
            catch (Exception) { }

            finally {

                mailMessaje.Dispose();
                smtpClient.Dispose();



            }

        }

    }
}