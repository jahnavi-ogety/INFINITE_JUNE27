using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CC_MVC1.Models;

namespace Assessment_1.Controllers
{
    public class CodeController : Controller
    {
        private northwindEntities db = new northwindEntities();
        public ActionResult GermanyCustomers()
        {
            var germanyCustomers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germanyCustomers);
        }

        public ActionResult CustomerDetailsWithOrderID()
        {
            var customerWithOrder = db.Customers
                .Join(db.Orders, c => c.CustomerID, o => o.CustomerID, (c, o) => new { Customer = c, Order = o })
                .Where(co => co.Order.OrderID == 10248)
                .Select(co => co.Customer)
                .FirstOrDefault();
            return View(customerWithOrder);
        }
    }
}