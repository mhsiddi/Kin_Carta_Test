using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kin_Carta_Automation.Models
{
    public class District
    {
        [JsonProperty("station_name")]
        public string StationName { get; set; }

        [JsonProperty("air_temperature")]
        public string AirTemp { get; set; }

        [JsonProperty("wet_bulb_temperature")]
        public string WetBultTemp { get; set; }

        [JsonProperty("humidity")]
        public string Humidity { get; set; }


    }
}
