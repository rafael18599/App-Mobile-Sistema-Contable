using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaContable.Models
{
    public class CasaCambio
    {
        [JsonProperty("compra")]
        public double compra { get; set; }

        [JsonProperty("venta")]
        public double venta { get; set; }
        [JsonProperty("origen")]
        public string origen { get; set; }

        [JsonProperty("moneda")]
        public string moneda { get; set; } 

        [JsonProperty("fecha")]
        public string fecha { get; set; }

    }
}
