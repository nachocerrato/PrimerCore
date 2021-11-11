using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            //aquí enviamos la información
            return View();
        }

        public IActionResult InformacionControllerView()
        {
            ViewBag.Nombre = "Alumno";
            ViewBag.Apellido = "Azure";
            ViewBag.Descripcion = "Estoy aprendiendo Net Core";
            ViewBag.Year = 2021;
            return View();
        }

        public IActionResult InformacionControllerViewModel()
        {
            List<Persona> personas = new List<Persona>();

            for (int i = 1; i <= 10; i++)
            {
                Persona person = new Persona();
                person.Nombre = "Persona " + i;
                person.Edad = 20 + i;
                person.Email = "persona" + i + "@gmail.com";
                personas.Add(person);
            }

            return View(personas);
        }

        public IActionResult InformacionGetViewController(String nombre, int edad)
        {
            ViewBag.Nombre = nombre;
            ViewBag.Edad = edad;
            return View();
        }

        [HttpGet]
        public IActionResult InformacionPostViewController()
        {
            return View();
        }

        //tenemos que crear un método con el mismo nombre que la vista
        //pero con la decoración [HttpPost]
        [HttpPost]
        public IActionResult InformacionPostViewController(String cajanombre, int cajaedad)
        {
            ViewBag.Nombre = cajanombre;
            ViewBag.Edad = cajaedad;
            return View();
        }
    }
}
