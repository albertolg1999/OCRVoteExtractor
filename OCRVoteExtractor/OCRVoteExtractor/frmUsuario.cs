using OCRVoteExtractor.clases;
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
    public partial class frmUsuario : Form
    {
        frmAdminUsuarios frau;
        Usuario usu;
        public frmUsuario()
        {
            InitializeComponent();
            frau = Owner as frmAdminUsuarios;
            lblModificar.Visible = false;
            btnModificar.Visible = false;
            btnNuevo.Visible = true;
            lblNuevo.Visible = true;

        }

        public frmUsuario(string modo,Usuario u)
        {
            InitializeComponent();

            frau = Owner as frmAdminUsuarios;
            this.usu = u;
            txtUser.Text = u.user;
            txtPass.Text = u.psw;
            txtCPass.Text = u.cpsw;
            lblModificar.Visible = true;
            btnModificar.Visible = true;
            btnNuevo.Visible = false;
            lblNuevo.Visible = false;
            


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearUsuario(txtUser.Text, txtPass.Text, txtCPass.Text,1);
            
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuario(this.usu);
        }

        private  void CrearUsuario(string user, string pass, string cpass, int rol)
        {
            frau = Owner as frmAdminUsuarios;
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
                        MessageBox.Show(strReader.ToString());
                        if (strReader ==null)
                        {
                            MessageBox.Show("El usuario ya existe en la bd");
                        }
                        else
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                if (responseBody != " ")
                                {
                                    // Do something with responseBody
                                    MessageBox.Show(responseBody);
                                    MessageBox.Show("Insertado correctamente");
                                }
                                else
                                {
                                    MessageBox.Show("El usuario ya existe en la bd");
                                }
                               
                            }
                        }

                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
                MessageBox.Show("El usuario ya existe en la bd");
            }

            this.frau.cargarDgv();
        }

        private void ModificarUsuario(Usuario usu)
        {

            frau = Owner as frmAdminUsuarios;
            var url = $"http://localhost:8080/app/modificarUser/{usu.id}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            //MessageBox.Show(request.ToString());
            string json = $"{{\"id\":\"{usu.id}\",\"user\":\"{txtUser.Text}\",\"psw\":\"{txtPass.Text}\",\"cpsw\":\"{txtCPass.Text}\",\"rol\":\"{usu.rol}\"}}";
            request.Method = "PUT";
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
                            MessageBox.Show("");
                        }
                        else
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                // Do something with responseBody
                                //MessageBox.Show(responseBody);
                                MessageBox.Show("Actualizado correctamente");
                            }
                        }

                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
                //MessageBox.Show("El usuario ya existe en la bd");
            }

            this.frau.cargarDgv();
        }
    }
}
