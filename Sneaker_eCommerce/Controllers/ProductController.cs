using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sneaker_eCommerce.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Product()
        {
            return View();
        }
    }
}