using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06.Models;

namespace TP06.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult traerDatoInteres(int id)
    {
        List<DatoInteres> datosInteres = BD.GetDatoInteres(id);
        if (datosInteres != null)
        {
            ViewBag.listaDatos = datosInteres;
            return View("");
        }
        else
        {
            ViewBag.mensaje = "No tiene datos de interes";
            return View("???");
        }
    }
}
