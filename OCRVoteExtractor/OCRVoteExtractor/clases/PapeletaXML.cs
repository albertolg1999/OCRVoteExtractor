using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRVoteExtractor.clases
{
    [JsonObject(Title ="papeleta")]
    public class PapeletaXML
    {
        [JsonProperty("representante")]
        public String Representante { get; set; }

        [JsonProperty("nombre")]
        public String Nombre { get; set; }
    }
}
