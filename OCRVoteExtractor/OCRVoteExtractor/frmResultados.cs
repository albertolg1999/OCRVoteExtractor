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
using System.Windows.Forms.DataVisualization.Charting;

namespace OCRVoteExtractor
{
    public partial class frmResultados : Form
    {
        Rutas r = new Rutas();
        List<Representantes_Votos> lista= new List<Representantes_Votos>();
        public frmResultados()
        {
            InitializeComponent();
        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            listarResultados();
            

            

        }

        private void cargarResultados()
        {
            chrtresultados.Titles.Add("Resultados");

            for(int i = 0; i < lista.Count; i++)
            {

                Series s = chrtresultados.Series.Add(lista[i].nombre);


                s.Label = lista[i].nombre.ToString();
                s.Points.Add(lista[i].votos);
                s.ToolTip= lista[i].nombre.ToString();

            }
        }
        private void listarResultados()
        {

            int rol = 1;
            var url = $"http://localhost:8080/app/resultados";
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

                                this.lista = JsonConvert.DeserializeObject<List<Representantes_Votos>>(responseBody);
                                MessageBox.Show(this.lista.Count.ToString());

                            }
                            else
                            {
                                //MessageBox.Show("No existen usuarios con este rol", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            cargarResultados();

        }

        

        private void btnExportar_Click(object sender, EventArgs e)
        {
            chrtresultados.SaveImage(this.r.ruta_temporales+"\\Grafica.png", ChartImageFormat.Png);

            MessageBox.Show("Gráfica guardada correctamente");
        }

       
    }
    
}
