using System;
using System.Web.Mvc;
using Lab03_MVC_Meza.Models;

namespace Lab03_MVC_Meza.Controllers
{
    public class DispensadorController : Controller
    {
        // GET: Dispensador
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Generar(ClsDispensador objDispensador)
        {
            if (objDispensador.Monto > 0)
            {
                double montoRestante = objDispensador.Monto;

                // Billetes
                objDispensador.b200 = (int)Math.Floor(montoRestante / 200);
                montoRestante %= 200;

                objDispensador.b100 = (int)Math.Floor(montoRestante / 100);
                montoRestante %= 100;

                objDispensador.b50 = (int)Math.Floor(montoRestante / 50);
                montoRestante %= 50;

                objDispensador.b20 = (int)Math.Floor(montoRestante / 20);
                montoRestante %= 20;

                objDispensador.b10 = (int)Math.Floor(montoRestante / 10);
                montoRestante %= 10;

                // Monedas
                objDispensador.m5 = (int)Math.Floor(montoRestante / 5);
                montoRestante %= 5;

                objDispensador.m2 = (int)Math.Floor(montoRestante / 2);
                montoRestante %= 2;

                objDispensador.m1 = (int)Math.Floor(montoRestante / 1);
                montoRestante %= 1;

                objDispensador.m050 = (int)Math.Floor(montoRestante / 0.50);
                montoRestante %= 0.50;

                objDispensador.m020 = (int)Math.Floor(montoRestante / 0.20);
                montoRestante %= 0.20;

                objDispensador.m010 = (int)Math.Floor(montoRestante / 0.10);
                montoRestante %= 0.10;

                objDispensador.m005 = (int)Math.Floor(montoRestante / 0.05);
                montoRestante %= 0.05;

                // Calcular totales
                objDispensador.CantidadBi = objDispensador.b200 + objDispensador.b100
                                          + objDispensador.b50 + objDispensador.b20
                                          + objDispensador.b10;

                objDispensador.CantidadMo = objDispensador.m5 + objDispensador.m2
                                          + objDispensador.m1 + objDispensador.m050
                                          + objDispensador.m020 + objDispensador.m010
                                          + objDispensador.m005;

            }
            else
            {
                Response.Write("<script language=javascript>alert('Ingrese un monto válido')</script>");
                return View("Index", objDispensador);
            }

            return View("Generar", objDispensador);
        }
    }
}
