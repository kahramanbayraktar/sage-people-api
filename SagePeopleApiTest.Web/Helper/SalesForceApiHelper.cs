using RestSharp;
using SagePeopleApiTest.Web.Models;

namespace SagePeopleApiTest.Web.Helper
{
    public class SalesForceApiHelper
    {
        private const string AuthorizationUrl = "https://login.salesforce.com/services/oauth2/token";
        private const string ResourceUriQuery = "https://na1.salesforce.com/services/data/v45.0/query/";
        private const string ResourceUriCustomObjects = "https://na1.salesforce.com/services/data/v45.0/sobjects/";

        private const string ClientId = "3MVG9I5UQ_0k_hTnCxkhecRh8wfckEWbMqRjk43AI_SSs5or8TPR2.9bOFvBj4PxD5zOPoIBUNHGQBSNDMHDF";
        private const string ClientSecret = "9C263017495424223F79617A951BCADF6556EE5A8592F4FC746B0210F3F77662";
        private const string GrantType = "password";
        private const string UserName = "kahraman.bayraktar@hr.ite-exhibitions.com";
        private const string Password = "5a9f0rcEAp1";

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
            var client = new RestClient(ResourceUriQuery + "?q=select+id,name,fRecruit__Location_City__c,fRecruit__Location_Country__c,fRecruit__Location_Region__c+from+fRecruit__Vacancy__c");
            var request = new RestRequest("", Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);

            var response = client.Execute<VacancyListModel>(request);
            return response.Data;
        }

        public static Vacancy GetVacancy(string accessToken, string vacancyId)
        {
            var client = new RestClient(ResourceUriCustomObjects + $"fRecruit__Vacancy__c/{vacancyId}");
            var request = new RestRequest("", Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);

            var response = client.Execute<Vacancy>(request);
            return response.Data;
        }
    }
}
