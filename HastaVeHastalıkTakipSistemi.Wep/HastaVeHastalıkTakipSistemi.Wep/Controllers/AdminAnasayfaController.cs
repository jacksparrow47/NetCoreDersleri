using Microsoft.AspNetCore.Mvc;

namespace HastaVeHastalıkTakipSistemi.Wep.Controllers
{
    public class AdminAnasayfaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}