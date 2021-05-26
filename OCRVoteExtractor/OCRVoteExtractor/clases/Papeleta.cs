using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OCRVoteExtractor.clases
{
    public class Papeleta
    {
        public string path_file;
        public string XML_file;
        public List<partido> partidosPapeleta;
        private string v;

        public Papeleta(string v)
        {
            this.path_file = v;
            this.partidosPapeleta = new List<partido>();
        }

        public void cargarPartidos()
        {
            XmlDocument xDoc;
            xDoc = new XmlDocument();
            partido p;
            xDoc.Load(XML_file);
            XmlNodeList papeleta = xDoc.GetElementsByTagName("papeleta");
            XmlNodeList cuadrado = ((XmlElement)papeleta[0]).GetElementsByTagName("cuadrado");
            foreach (XmlElement cuadro in cuadrado)
            {
                p = new partido();
                XmlNodeList nombre = cuadro.GetElementsByTagName("nombrePartido");
                p.Nombre = ((XmlElement)nombre[0]).InnerText.ToString();
                XmlNodeList representante = cuadro.GetElementsByTagName("representante");
                p.Representante = ((XmlElement)representante[0]).InnerText.ToString();
                XmlNodeList distX = cuadro.GetElementsByTagName("distCuadroX");
                p.DistX = int.Parse(((XmlElement)distX[0]).InnerText.ToString());
                XmlNodeList distY = cuadro.GetElementsByTagName("distCuadroY");
                p.DistY = int.Parse(((XmlElement)distY[0]).InnerText.ToString());
                XmlNodeList ancho = cuadro.GetElementsByTagName("anchoCuadro");
                p.Ancho = int.Parse(((XmlElement)ancho[0]).InnerText.ToString());
                XmlNodeList alto = cuadro.GetElementsByTagName("altoCuadro");
                p.Alto = int.Parse(((XmlElement)alto[0]).InnerText.ToString());
                p.Marcado = false;
                partidosPapeleta.Add(p);
                //MessageBox.Show(p.Nombre);
            }
        }
    }
}
