using System.Collections.Generic;

namespace SagePeopleApiSample.Web.Models
{
    public class VacancyListModel
    {
        public int TotalSize { get; set; }
        public bool Done { get; set; }
        public List<Vacancy> Records { get; set;}
    }
}
