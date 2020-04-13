using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string ValueTreatment(int value)
        {
            string answ ;
            int factorial=1;
            if (value < 0)
            {
                answ = "Отрицательное значение";
                return answ;
            }
            else if (value == 0)
            {
                answ="Ноль";
                return answ;
            }
            else if (value <=10 && value >= 1)
            {
                for(int i = 1; i<=value; i++)
                {
                    factorial *= i;

                }
                answ = "Факториал = " + factorial;
                return answ;
                
            }
            else if (value >= 11)
            {
                answ = "Положительное число";
                return answ;
            }
            else
            {
                answ = "Ошибка";
                return answ;
            }
            

        }
        
    }
}