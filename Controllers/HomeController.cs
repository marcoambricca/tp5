using Microsoft.AspNetCore.Mvc;

namespace TP5.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(string nombre)
    {
        Escape.nombreUsuario = nombre;
        ViewBag.nombre = nombre;
        ViewBag.segundos = 0;
        ViewBag.minutos = 0;
        if(nombre != null)return View("Habitacion1");
        return View();
    }

    public IActionResult Habitacion(int sala, string clave)
    {
        ViewBag.nombre = Escape.nombreUsuario;
        ViewBag.segundos = (DateTime.Now - Escape.GetTiempo()).Seconds;
        ViewBag.minutos = (DateTime.Now - Escape.GetTiempo()).Minutes;
        
        if(((sala != 0) && !Escape.ResolverSala(sala, clave))){
            ViewBag.MensajeError = "Respuesta incorrecta!!!";
        }
        if(Escape.GetEstadoJuego() == 5){
            ViewBag.CantErrores = Escape.GetErrores();
            return View("Victoria");
        }
        return View("Habitacion"+Escape.GetEstadoJuego());
    }
    public IActionResult Victoria()
    {
        return View();
    }
    public IActionResult Creditos()
    {
        return View();
    }
}
