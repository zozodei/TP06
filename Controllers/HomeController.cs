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
        } 
        return View();
    }

    public IActionResult InicioSesion (string Email, String Contraseña) 
    {
        
        int id = BD.Login (Email, Contraseña);
        if (id >-1)
        {
            HttpContext.Session.SetString ("IdUser", id.ToString());
             ViewBag.Usuario = BD.GetUsuario(id);
            return View ("Logueado");
        }
        else
        {
            return View("Index");
        }
        
    }


    public IActionResult cerrarSesion () 
    {
        HttpContext.Session.Remove("IdUser");
        return View ("Index"); 
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
            return View("");
        }
        
    }
    public IActionResult traerDatoFamiliar(int id)
    {
        List<DatoFamiliar> datosFamiliares = BD.GetDatoFamiliar(id);
        if (datosFamiliares != null)
        {
            ViewBag.listaDatos = datosFamiliares;
            return View("");
        }
        else
        {
            ViewBag.mensaje = "No tiene datos de interes";
            return View("");
        }
    }


}
