using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab03_MVC_Meza.Models;

namespace Lab03_MVC_Meza.Controllers
{
    public class CompraController : Controller
    {
        // GET: Compra
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularCompra(ClsCompra objCompra)
        {
            Random valor = new Random();
            objCompra.ramdon = valor.Next(1, 200);
            return View(objCompra);
        }
    }
}