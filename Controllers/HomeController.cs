using Microsoft.AspNetCore.Mvc;

namespace TP5.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tutorial()
    {
        return View();
    }
    public IActionResult Habitacion(int sala, string clave)
    {
        ViewBag.tiempo = (DateTime.Now - Escape.GetTiempo()).Seconds;
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
