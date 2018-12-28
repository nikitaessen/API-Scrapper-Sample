using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SurveyGizmo.Models
{
    public class SurveyRequestData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("is_test_data")]
        public bool IsTestData { get; set; }

        [JsonProperty("date_submitted")]
        public DateTime DateSubmitted { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("ip_address")]
        public string IdAddress { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("location")]
        public LocationData Location { get; set; }

        [JsonProperty("date_started")]
        public DateTime DateStarted { get; set; }

        [JsonProperty("url_variables")]
        public List<UrlVariableModel> UrlVariables { get; set; }

        [JsonProperty("pages")]
        public List<Page> Pages { get; set; }
    }
}
