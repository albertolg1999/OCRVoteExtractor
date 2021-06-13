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
            if (txtUser.Text == "" || txtPass.Text == "" || txtCPass.Text == "")
            {
                MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtPass.Text.ToLower().Equals(txtCPass.Text.ToLower()))
                {
                    CrearUsuario(txtUser.Text, txtPass.Text, txtCPass.Text, 1);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            txtCPass.PasswordChar = '*';
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "" || txtCPass.Text == "")
            {
                MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtPass.Text.ToLower().Equals(txtCPass.Text.ToLower()))
                {
                    ModificarUsuario(this.usu);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        //Método para realizar peticion post al servidor para insertar un nuevo usuario
        private  void CrearUsuario(string user, string pass, string cpass, int rol)
        {
            frau = Owner as frmAdminUsuarios;
            try {
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
                            //MessageBox.Show(strReader.ToString());
                            if (strReader == null)
                            {

                            }
                            else
                            {
                                using (StreamReader objReader = new StreamReader(strReader))
                                {
                                    string responseBody = objReader.ReadToEnd();
                                    if (responseBody != "Usuario insertado correctamente")
                                    {
                                        MessageBox.Show("El usuario ya existe en la bd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                   // MessageBox.Show("El usuario ya existe en la bd");
                }

                this.frau.cargarDgv();
            }
            catch (WebException ex)
            {
                MessageBox.Show("No existe conexion con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Método para realizar peticion put al servidor para modificar un usuario
        private void ModificarUsuario(Usuario usu)
        {

            frau = Owner as frmAdminUsuarios;
            try
            {
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
            catch (WebException ex)
            {
                MessageBox.Show("No existe conexion con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnVerpsw_Click(object sender, EventArgs e)
        {
            btnVerpsw.Visible = false;
            this.btnOcultar.Visible = true;
            txtPass.PasswordChar = '\0';
            txtCPass.PasswordChar = '\0';
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            btnVerpsw.Visible = true;
            this.btnOcultar.Visible = false;
            txtPass.PasswordChar = '*';
            txtCPass.PasswordChar = '*';
        }
    }
}
