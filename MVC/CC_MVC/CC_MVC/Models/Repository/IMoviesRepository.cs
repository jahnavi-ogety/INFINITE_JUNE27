using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace CC_MVC.Models.Repository
{
    public class IMoviesRepository :Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}