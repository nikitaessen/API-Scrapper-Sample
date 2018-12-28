using System.Collections.Generic;
using Newtonsoft.Json;

namespace SurveyGizmo.Models
{
    public class SurveyResponsesData
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errors")]
        public List<Error> Errors { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
