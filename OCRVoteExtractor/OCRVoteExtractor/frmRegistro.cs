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
        public frmRegistro()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            PutItem(txtUser.Text, txtPass.Text, txtCPass.Text, 1);
        }

       
        private static void PutItem(string user, string pass,string cpass,int rol)
        {
            var url = $"http://localhost:8080/app/guardar";
            var request = (HttpWebRequest)WebRequest.Create(url);
            MessageBox.Show(request.ToString());
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
                            MessageBox.Show("No insertado");
                        }
                        else
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                // Do something with responseBody
                                MessageBox.Show("Insertado correctamente");
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
        }

        private static void DeleteItem(int id)
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
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            MessageBox.Show("Eliminado correctamente");
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("El usuario no existe actualmente en la bd");
            }
        }

        private void btnScanners_Click(object sender, EventArgs e)
        {
            int id;
            if (txtUser.Text == "")
            {
                MessageBox.Show("Introduzca un id");
            }
            else
            {
                id = int.Parse(txtUser.Text);
                DeleteItem(id);
            }
               
             
            
        }
    }
    
}
