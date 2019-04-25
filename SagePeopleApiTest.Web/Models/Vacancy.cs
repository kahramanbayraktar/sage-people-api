namespace SagePeopleApi.Web.Models
{
    public class Vacancy
    {
        public Attributes Attributes { get; set; }
        public string Id { get; set; }
        public string OwnerId { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedById { get; set; }
        public string LastModifiedDate { get; set; }
        public string LastModifiedById { get; set; }
        public string SystemModstamp { get; set; }
        public string LastActivityDate { get; set; }
        public string LastViewedDate { get; set; }
        public string LastReferencedDate { get; set; }
        public string fRecruit__Candidate_Portal_URL__c { get; set; }
        public string fRecruit__Description__c { get; set; }
        public string fRecruit__Key_Responsibilities__c { get; set; }
        public string fRecruit__Location_City__c { get; set; }
        public string fRecruit__Location_Country__c { get; set; }
        public string fRecruit__Location_Region__c { get; set; }
        public string fRecruit__Salary_Period__c { get; set; }
        public string fRecruit__Status__c { get; set; }
        public string fRecruit__Vacancy_No__c { get; set; }
    }
}
