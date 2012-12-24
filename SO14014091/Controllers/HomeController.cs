using SO14014091.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SO14014091.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new List<Product>();
            model.Add(new Product() { Id = 122, Name = "Apple Juice", Description = "Best juice in the house" });
            model.Add(new Product() { Id = 132, Name = "Orange Juice", Description = "Made with only the best oranges" });
            model.Add(new Product() { Id = 142, Name = "Strawberry Juice", Description = "If only I could say something .... WOW!" });
            model.Add(new Product() { Id = 152, Name = "pineapple Juice", Description = "Only with Brazilian pineapples" });
            model.Add(new Product() { Id = 162, Name = "Coconut Juice", Description = "Directly from Dominican Republic" });

            return View(model);
        }
    }
}
