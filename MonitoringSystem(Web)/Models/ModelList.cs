using MonitoringSystemModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoringSystem_Web_.Models
{
    public class TemplateToMarks
    {
        [JsonProperty("rbn")]
        public string rbn { get; set; }
        [JsonProperty("inputId")]
        public string inputId { get; set; }
        [JsonProperty("markType")]
        public string markType { get; set; }
        [JsonProperty("inputvalue")]
        public string inputvalue { get; set; }
        [JsonProperty("dateOfReport")]
        public DateTime dateOfReport { get; set; }
        [JsonProperty("dateOfProgram")]
        public DateTime dateOfProgram { get; set; }
    }

    
}