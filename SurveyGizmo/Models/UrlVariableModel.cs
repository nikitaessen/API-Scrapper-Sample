using Newtonsoft.Json;

namespace SurveyGizmo.Models
{
    public class UrlVariableModel
    {
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
