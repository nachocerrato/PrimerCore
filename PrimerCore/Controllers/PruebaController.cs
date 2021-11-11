using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class PruebaController : Controller
    {
        //estamos indicando que tendremos una vista llamada Index dentro de Views/Prueba
        public IActionResult Index()
        {
            return View();
        }
    }
}
