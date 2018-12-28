using System.Collections.Generic;
using Newtonsoft.Json;

namespace SurveyGizmo.Models
{
    public class Page
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("questions")]
        public List<Question> Questions { get; set; }
    }
}
