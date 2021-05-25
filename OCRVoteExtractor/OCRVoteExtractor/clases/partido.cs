using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRVoteExtractor.clases
{
    public class partido
    {
        private String representante;

        public String Representante
        {
            get { return representante; }
            set { representante = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        

        private int distX;

        public int DistX
        {
            get { return distX; }
            set { distX = value; }
        }
        private int distY;

        public int DistY
        {
            get { return distY; }
            set { distY = value; }
        }

        private int alto;

        public int Alto
        {
            get { return alto; }
            set { alto = value; }
        }

        private int ancho;

        public int Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }

        private bool marcado;

        public bool Marcado
        {
            get { return marcado; }
            set { marcado = value; }
        }

    }
}
