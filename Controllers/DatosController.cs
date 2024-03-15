using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mycursoapp.Models;

namespace mycursoapp.Controllers
{
    
    public class DatosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Nombre,Categoria,Creditos,Modalidad,IncluyeMaterial,IncluyeVideos,Horas")] Datos datos)
        {
            if (ModelState.IsValid)
            {
           
                ViewData["Message"] = "Registro correcto! " +
                    "\nCurso: "+ datos.Nombre+
                    "\nCategoria: "+ datos.Categoria+
                    "\nPago Total: "+ datos.Pago();
              
                return View("Index");
            }

            return View("Index");
        }
    }
}

