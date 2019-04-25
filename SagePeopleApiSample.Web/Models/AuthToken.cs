namespace SagePeopleApiSample.Web.Models
{
    public class AuthToken
    {
        public string AccessToken { get; set; }
        public string InstanceUrl { get; set; }
        public string Id { get; set; }
        public string TokenType { get; set; }
        public string IssuedAt { get; set; }
        public string Signature { get; set; }
    }
}
