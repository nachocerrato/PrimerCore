using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class PracticasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MenuPracticasView()
        {
            return View();
        }

        public IActionResult EjemploColeccionesPracticasView()
        {
            List<Comic> comics = new List<Comic>();

            Comic comic = new Comic();
            comic.Nombre = "Wolverine";
            comic.Descripcion = "Hombre wolvo";
            comic.Imagen = "https://images6.alphacoders.com/873/873021.jpg";
            comics.Add(comic);

            comic = new Comic();
            comic.Nombre = "Spiderman";
            comic.Descripcion = "Hombre aragna";
            comic.Imagen = "https://www.desktopbackground.org/p/2015/11/12/1041188_comics-spider-man-marvel-wallpapers-for-high-resolution-hd-16-9_1920x1200_h.jpg";

            comics.Add(comic);

            comic = new Comic();
            comic.Nombre = "Ironman";
            comic.Descripcion = "Hombre errático";
            comic.Imagen = "https://wallpapersmug.com/download/1600x900/ad84c3/iron-man-comicart-4k.jpg";

            comics.Add(comic);

            return View(comics);
        }

        [HttpGet]
        public IActionResult SumaNumerosPostView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumaNumerosPostView(int num1, int num2, int total)
        {
            ViewBag.Numero1 = num1;
            ViewBag.Numero2 = num2;
            ViewBag.Total = num1 + num2;

            return View();
        }

        [HttpGet]
        public IActionResult SumaNumerosGetView(int nume1, int nume2, int totale)
        {
            ViewBag.Numero1 = nume1;
            ViewBag.Numero2 = nume2;
            ViewBag.Total = nume1 + nume2;
            return View();
        }
    }
}
