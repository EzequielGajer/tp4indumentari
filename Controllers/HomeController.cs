using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp4indumentari.Models;

namespace tp4indumentari.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult GuardarIndumentaria(string equipoSeleccionado, string media, string pantalon, string remera, Indumentaria indumentaria)
    {
        if (string.IsNullOrEmpty(equipoSeleccionado) || string.IsNullOrEmpty(media) || string.IsNullOrEmpty(pantalon) || string.IsNullOrEmpty(remera))
        {
            ViewBag.ErrorMensaje = "Los parámetros no son correctos";
            ViewBag.ListaEquipos = Equipos.ListaEquipos;
            ViewBag.ListaMedias = Equipos.ListaMedias;
            ViewBag.ListaPantalones = Equipos.ListaPantalones;
            ViewBag.ListaRemeras = Equipos.ListaRemeras;
            return View();
        }

     if (Equipos.IngresarIndumentaria(equipoSeleccionado, indumentaria))
        {
            ViewBag.ErrorMessage = "El equipo ya ha cargado su indumentaria";
            ViewBag.ListaEquipos = Equipos.ListaEquipos;
            ViewBag.ListaMedias = Equipos.ListaMedias;
            ViewBag.ListaPantalones = Equipos.ListaPantalones;
            ViewBag.ListaRemeras = Equipos.ListaRemeras;
            return View();
        }

        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }
}
