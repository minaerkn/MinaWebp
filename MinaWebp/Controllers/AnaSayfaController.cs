using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace MinaWebp.Controllers
{
    public class AnaSayfaController : Controller
    {


        Context c = new Context();
        public ActionResult Index()
        {
            
            return View();
        }
       
    }
}