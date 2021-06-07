using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCRVoteExtractor
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition=FormStartPosition.CenterScreen;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro r = new frmRegistro();
            r.Show();
            this.Hide();
            
        }

        private void btnScanners_Click(object sender, EventArgs e)
        {
            comprobarLogin(txtUser.Text,txtPass.Text);
            this.Hide();
        }
        public static int invertirYBuscarRol(char[] normal)
        {
            string invert = "";
            for(int i = normal.Length - 1; i > 0; i--)
            {
                invert += normal[i];
            }

            
            string rol =invert.Substring(1,1);

            int id_rol = int.Parse(rol);
            return id_rol;
        }

        private static void comprobarLogin(String user, String psw)
        {
            var url = $"http://localhost:8080/app/login/{user}/{psw}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                            if (responseBody.Length > 0)
                            {
                                char[] normal = responseBody.ToCharArray();
                                MessageBox.Show("Usuario: " + user + ", se ha logeado correctamente");
                                if (invertirYBuscarRol(normal) == 1)
                                {
                                    Form1 f = new Form1();
                                    f.Show();
                                }
                                //MessageBox.Show(responseBody.ToString());
                                
                                
                            }
                            else
                            {
                                MessageBox.Show("Usuario: " + user + " no existe, por favor registrese para acceder al sistema");
                            }
                            // Do something with responseBody
                           
                                
                            }
                        }
                        
                    }
                
            }
            catch (WebException ex)
            {
                MessageBox.Show("No existe.Debe registrarse");
            }
            finally
            {
                
            }
            
        }
        

    }
}
