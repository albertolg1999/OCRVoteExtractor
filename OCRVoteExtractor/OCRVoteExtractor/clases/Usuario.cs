using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRVoteExtractor.clases
{
    public class Usuario
    {
        public int id { get; set; }
        public string user { get; set; }
        public string psw { get; set; }
        public string cpsw { get; set; }
        public int rol { get; set; }

    }
}
