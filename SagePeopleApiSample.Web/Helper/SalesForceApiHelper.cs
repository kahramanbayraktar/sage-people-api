using RestSharp;
using SagePeopleApiSample.Web.Models;

namespace SagePeopleApiSample.Web.Helper
{
    public class SalesForceApiHelper
    {
        private const string AuthorizationUrl = "https://login.salesforce.com/services/oauth2/token";
        private const string ResourceUrlQuery = "https://na1.salesforce.com/services/data/v45.0/query/";
        private const string ResourceUrlCustomObjects = "https://na1.salesforce.com/services/data/v45.0/sobjects/";

        private const string ClientId = "{yourclientid}";
        private const string ClientSecret = "{yourclientsecret}";
        private const string GrantType = "password";
        private const string UserName = "{youremail}";
        private const string Password = "{yourpassword}";

        public static AuthToken AuthorizeByUsernamePassword()
        {
            var client = new RestClient(AuthorizationUrl);
            var request = new RestRequest("", Method.POST);
            request.AddParameter("client_id", ClientId);
            request.AddParameter("client_secret", ClientSecret);
            request.AddParameter("grant_type", GrantType);
            request.AddParameter("username", UserName);
            request.AddParameter("password", Password);

            var response = client.Execute<AuthToken>(request);
            return response.Data;
        }

        public static VacancyListModel ListVacancies(string accessToken)
        {
            var client = new RestClient(ResourceUrlQuery + "?q=select+id,name,fRecruit__Location_City__c,fRecruit__Location_Country__c,fRecruit__Location_Region__c+from+fRecruit__Vacancy__c");
            var request = new RestRequest("", Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);

            var response = client.Execute<VacancyListModel>(request);
            return response.Data;
        }

        public static Vacancy GetVacancy(string accessToken, string vacancyId)
        {
            var client = new RestClient(ResourceUrlCustomObjects + $"fRecruit__Vacancy__c/{vacancyId}");
            var request = new RestRequest("", Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);

            var response = client.Execute<Vacancy>(request);
            return response.Data;
        }
    }
}
