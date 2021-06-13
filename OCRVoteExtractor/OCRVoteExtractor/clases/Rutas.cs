using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRVoteExtractor.clases
{
    public class Rutas
    {
        public String rc_imag = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()+"\\imagen";
        public String ruta_papeletas = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()+"\\papeletas";
        public String ruta_temporales = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()+"\\temporal";
        public String ruta_xml = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()+"\\xml";

    }
}
