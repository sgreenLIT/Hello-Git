using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mar28Git.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            Response.Write("Hello from Index Page.");
        }

    }
}
