using SurveyGizmo.Models;
using SurveyGizmo.Services;

namespace SurveyGizmo
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new SurveyGizmoApiService();

            //Create request data
            var requestData = new SurveyRequestData()
            {
                //TODO send data
            };

            var responseData = api.GetResponses("1234", requestData).Result;
        }
    }
}