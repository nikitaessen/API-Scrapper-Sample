using System.Collections.Generic;
using Newtonsoft.Json;

namespace SurveyGizmo.Models
{
    public class Question
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("shown")]
        public string Shown { get; set; }

        [JsonProperty("comments_value")]
        public string Comment { get; set; }

        [JsonProperty("options")]
        public List<Option> Options { get; set; }
    }
}
