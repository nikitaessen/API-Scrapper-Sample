using System;
using System.Linq;
using System.Text;
using SurveyGizmo.Extensions;

namespace SurveyGizmo.Services
{
    public class UriMaker
    {
        public const string SLASH = "/";

        public Uri Combine(string baseUrl, params string[] pathFragments)
        {
            if (pathFragments.Length == 0)
            {
                throw new ArgumentException("Uri fragments is not defined", nameof(pathFragments));
            }

            var uriStrBuilder = new StringBuilder();

            uriStrBuilder.Append(baseUrl.EnsureNotEndsWith(SLASH));

            pathFragments.Aggregate(
                uriStrBuilder,
                (url, fragment) =>
                    url.Append(fragment.EnsureStartsWith(SLASH).EnsureNotEndsWith(SLASH)));

            return new Uri(uriStrBuilder.ToString());
        }
    }
}
