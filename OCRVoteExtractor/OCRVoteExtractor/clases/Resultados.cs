using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRVoteExtractor.clases
{
    //[JsonObject(Title = "resultados")]
    public class Resultados
    {
        public List<PapeletaXML> Papeletas { get; set; } = new List<PapeletaXML>();
    }
}
