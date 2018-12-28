using Newtonsoft.Json;

namespace SurveyGizmo.Models
{
    public class Error
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
