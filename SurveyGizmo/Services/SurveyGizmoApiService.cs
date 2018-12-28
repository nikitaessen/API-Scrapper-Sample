using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SurveyGizmo.Models;

namespace SurveyGizmo.Services
{
    //That service written to work with SG OEM API, so we need OEM API Key to work with real data. Now working with simple mock server
    //
    public class SurveyGizmoApiService
    {
        private const string SURVEYS_PATH_FRAGMENT = "surveys";
        private const string RESPONSES_PATH_FRAGMENT = "responses";

        private const string TEST_HOST = "https://36176d08-0dbb-4dc7-a782-d7ee30639611.mock.pstmn.io";

        private readonly HttpService _httpService;
        private readonly UriMaker _uriMaker;

        public SurveyGizmoApiService()
        {
            _uriMaker = new UriMaker();
            _httpService = new HttpService();
        }

        public async Task<SurveyResponsesData> GetResponses(string surveyId, SurveyRequestData data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            var path = _uriMaker.Combine(TEST_HOST, SURVEYS_PATH_FRAGMENT, surveyId, RESPONSES_PATH_FRAGMENT);

            var result = await _httpService.Post(path, new StringContent(json));

            //TODO excetion handling
            if (result.StatusCode != HttpStatusCode.OK)
            {
                throw new WebException("Get request failed!");
            }

            var content = await result.Content.ReadAsStringAsync();

            var deserializedObject =
                JsonConvert.DeserializeObject<SurveyResponsesData>(content);

            return deserializedObject;
        }
    }
}
