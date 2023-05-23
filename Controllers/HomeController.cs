using Microsoft.AspNetCore.Mvc;

namespace TP4BIS.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListP = info.ListarPaises();
        return View();
    }
    public IActionResult DetallePais(string Paises)
    {
        ViewBag.Pais= info.BuscarPais(Paises);
        return View("detallePais");
    }
}
