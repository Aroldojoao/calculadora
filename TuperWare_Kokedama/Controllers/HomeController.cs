using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aroldo_MVC_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            ViewBag.Message = "Sua Aplicação descrita na Pagina";

            return View();
        }

        public ActionResult about()
        {
            ViewBag.Message = "Sua Aplicação descrita na Pagina";

            return View();
        }
        public ActionResult Contato()
        {
            ViewBag.Message = "Sua pagina de Contato";

            return View();
        }

        public ActionResult Formulario()
        {
            ViewBag.Message = "Bem vindo, Preencha seus dados";

            return View();
        }
        
        public ActionResult Produtos()
        {
            ViewBag.Message = "Produtos";

            return View();
        }
    }
}