﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SagePeopleApiSample.Web.Helper;
using SagePeopleApiSample.Web.Models;

namespace SagePeopleApiSample.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var token = SalesForceApiHelper.AuthorizeByUsernamePassword();

            Response.Cookies.Append("AuthToken", JsonConvert.SerializeObject(token));

            var vacancyListModel = SalesForceApiHelper.ListVacancies(token.AccessToken);

            return View(vacancyListModel);
        }

        public IActionResult Details(string id)
        {
            var token = JsonConvert.DeserializeObject<AuthToken>(HttpContext.Request.Cookies["AuthToken"]);

            var vacancy = SalesForceApiHelper.GetVacancy(token.AccessToken, id);

            return View(vacancy);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
