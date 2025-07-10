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
         int existeUsuario;
        if ( HttpContext.Session.GetString ("IdUser") != null ) 
        {
            existeUsuario  = Convert.ToInt32(HttpContext.Session.GetString ("IdUser"));
            ViewBag.Usuario = BD.GetUsuario(existeUsuario);
        } else if () {}
        return View();
    }



    public IActionResult InicioSesion (string Email, string Contraseña) 
    {

       
    }

}
