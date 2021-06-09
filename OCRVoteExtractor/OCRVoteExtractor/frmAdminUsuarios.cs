using Newtonsoft.Json;
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
    public partial class frmAdminUsuarios : Form
    {
        List<Usuario> lista;

        public frmAdminUsuarios()
        {
            InitializeComponent();
        }

        private void frmAdminUsuarios_Load(object sender, EventArgs e)
        {
            cargarDgv();
            dgvUsuarios.Refresh();
        }

        public void cargarDgv()
        {
            listarUsuariosRol();
            dgvUsuarios.DataSource = lista.ToList();
            dgvUsuarios.Columns[0].HeaderText = "Id Usuario";
            dgvUsuarios.Columns[1].HeaderText = "Usuario";
            dgvUsuarios.Columns[2].HeaderText = "Password";
            dgvUsuarios.Columns[3].HeaderText = "Conf.Password";
            dgvUsuarios.Columns[4].Visible = false;
            //dgvUsuarios.Columns.RemoveAt(4);
            dgvUsuarios.Refresh();
            dgvUsuarios.Rows[0].Selected = true;
        }
        private void listarUsuariosRol()
        {

            int rol = 1;
            var url = $"http://localhost:8080/app/usuarios/{rol}";
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
                            //MessageBox.Show(responseBody.Length.ToString());
                            if (responseBody.Length > 0)
                            {
                                //char[] normal = responseBody.ToCharArray();
                                //MessageBox.Show(responseBody);

                                this.lista = JsonConvert.DeserializeObject<List<Usuario>>(responseBody);
                                
                            }
                            else
                            {
                                MessageBox.Show("No existen usuarios con este rol","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            // Do something with responseBody


                        }
                    }

                }

            }
            catch (WebException ex)
            {
               // MessageBox.Show("No existe.Debe registrarse");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult rs = MessageBox.Show("¿Desea eliminar este usuario seguro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                DeleteUsuario(id);

            }
            cargarDgv();
        }

        private static void DeleteUsuario(int id)
        {
            var url = $"http://localhost:8080/app/delete/{id}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null)
                        {
                            MessageBox.Show("El usuario no existe actualmente en la bd");
                        }
                        else
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                // Do something with responseBody
                                MessageBox.Show("Eliminado correctamente");
                            }
                        }
                        
                    }
                }
            }
            catch (WebException ex)
            {
                //MessageBox.Show("El usuario no existe actualmente en la bd");
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            frmUsuario fru = new frmUsuario();
            fru.Owner = this;
            fru.ShowDialog();
        }

        private void btnModicar_Click(object sender, EventArgs e)
        {
            int index = dgvUsuarios.SelectedRows[0].Index;
            Usuario u = lista[index];

            frmUsuario fru = new frmUsuario("actualizar",u);
            fru.Owner = this;
            fru.ShowDialog();
        }
    }
}
