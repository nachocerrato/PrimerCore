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
    }
}
