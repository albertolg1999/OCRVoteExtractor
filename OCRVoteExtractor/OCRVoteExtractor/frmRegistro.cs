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
    public partial class frmRegistro : Form
    {
        frmLogin fl;
        public frmRegistro(frmLogin frl)
        {
            this.fl = frl;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "" || txtCPass.Text == "")
            {
                MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtPass.Text.ToLower().Equals(txtCPass.Text.ToLower()))
                {
                    registrarUsuario(txtUser.Text.ToLower(), txtPass.Text.ToLower(), txtCPass.Text.ToLower(), 1);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

       
        private static void registrarUsuario(string user, string pass,string cpass,int rol)
        {
            try
            {
                var url = $"http://localhost:8080/app/guardar";
                var request = (HttpWebRequest)WebRequest.Create(url);
                //MessageBox.Show(request.ToString());
                string json = $"{{\"user\":\"{user}\",\"psw\":\"{pass}\",\"cpsw\":\"{cpass}\",\"rol\":\"{rol}\"}}";
                request.Method = "POST";
                //\"id\":\"{id}\",
                request.ContentType = "application/json";
                request.Accept = "application/json";
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                try
                {
                    using (WebResponse response = request.GetResponse())
                    {
                        using (Stream strReader = response.GetResponseStream())
                        {
                            if (strReader == null)
                            {
                                
                            }
                            else
                            {
                                using (StreamReader objReader = new StreamReader(strReader))
                                {
                                    string responseBody = objReader.ReadToEnd();
                                    if(responseBody!= "Usuario insertado correctamente")
                                    {
                                        MessageBox.Show("El usuario ya existe en la bd","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Insertado correctamente");
                                        
                                    }
                                    // Do something with responseBody
                                   
                                }
                            }

                        }
                    }
                }
                catch (WebException ex)
                {

                    // Handle error

                    MessageBox.Show("El usuario ya existe en la bd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            catch(WebException ex)
            {
                MessageBox.Show("No existe conexion con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        

        

        private void btnVerpsw_Click(object sender, EventArgs e)
        {
            btnVerpsw.Visible = false;
            this.btnOcultarpsw.Visible = true;
            txtPass.PasswordChar = '\0';
            txtCPass.PasswordChar = '\0';
        }

        private void btnOcultarpsw_Click(object sender, EventArgs e)
        {
            btnVerpsw.Visible = true;
            this.btnOcultarpsw.Visible = false;
            txtPass.PasswordChar = '*';
            txtCPass.PasswordChar = '*';
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.fl.Show();
            this.fl.limpiarCampos();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            txtCPass.PasswordChar = '*';
        }
    }
    
}
