using Newtonsoft.Json;

namespace SurveyGizmo.Models
{
    public class Option
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("answer_selected")]
        public bool SelectedAnswer { get; set; }

        [JsonProperty("answer_value")]
        public string AnswerValue { get; set; }

        [JsonProperty("other_value")]
        public string OtherValue { get; set; }
    }
}
