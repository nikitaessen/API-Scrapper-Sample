using System.Collections.Generic;
using Newtonsoft.Json;

namespace SurveyGizmo.Models
{
    public class Data
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("contact_id")]
        public string ContactId { get; set; }

        [JsonProperty("date_submitted")]
        public string DateSubmitted { get; set; }

        [JsonProperty("pages")]
        public List<Page> Pages { get; set; }
    }
}
