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

    public IActionResult InicioSesion (string Email, string Contraseña) 
    {
        int existeUsuario;
        existeUsuario = BD.Login(Email,Contraseña);
        

       
    }

}
