using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using SiscomsoftVendors_Plan.Models;
using SiscomsoftVendors_Plan.ViewModel;
using SiscomsoftVendors_Plan.Comun;

namespace SiscomsoftVendors_Plan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult Registro()
        {
            return View() ;
        }
        public ActionResult Actividades()
        {
            return View();
        }
        public ActionResult Representantes()
        {
            return View();
        }
        public ActionResult Localidades()
        {
            return View();
        }
    }
}