using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using codicioso.Models;
namespace codicioso.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cambio(string dinero){
            int cinco=5;
            int total1=0,total2=0,total3=0,total4=0,total5=0;
            decimal devuelto=decimal.Parse(dinero, CultureInfo.InvariantCulture.NumberFormat);
            decimal resultador1=devuelto/cinco;
            if(resultador1>=1){
            total1=(int)resultador1;
            devuelto=(decimal) devuelto-total1*5;
            }
            decimal resultador2=devuelto/1;
            if(resultador2>=1){
            total2=(int)resultador2;
            devuelto=(decimal) devuelto-total2*1;
            }
            decimal resultador3=devuelto/0.5m;
            if(resultador3>=1){
            total3=(int)resultador3;
            devuelto=(decimal) devuelto-total3*0.5m;
            }
            decimal resultador4=devuelto/0.1m;
            if(resultador4>=1){
           total4=(int)resultador4;
            devuelto=(decimal) devuelto-total4*0.1m;
            }
            decimal resultador5=devuelto/0.01m;
            if(resultador5>=1){
            total5=(int)resultador5;
            devuelto=(decimal) devuelto-total5*0.01m;
            }
            int total=total1+total2+total3+total4+total5;
            ViewBag.ok0=total;
            ViewBag.ok1=total1;
            ViewBag.ok2=total2;
            ViewBag.ok3=total3;
            ViewBag.ok4=total4;
            ViewBag.ok5=total5;
            return View();
        }
    }
}