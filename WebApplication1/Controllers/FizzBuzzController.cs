using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Count()
        {
            Licz l = new Licz();
            return View(l);
        }
        [HttpPost]
        public ActionResult Count(Licz licz)
        {
            if (licz.liczba < 1 || licz.liczba > 100)
            {
                licz.wynik = "Nieprawidlowe dane!";
                return View("out", licz);
            }
            if (licz.liczba %3 == 0 && licz.liczba % 5 == 0)
            {
                licz.wynik = "FizzBuzz";
                return View("out", licz);
            }
            if (licz.liczba % 3 == 0)
            {
                licz.wynik = "Fizz";
                return View("out", licz);
            }
            if (licz.liczba % 5 == 0)
            {
                licz.wynik = "Buzz";
                return View("out", licz);
            }
            else
            {
                licz.wynik = licz.liczba.ToString("0");
                return View("out", licz);
            }
        }
    }
}