using HastaVeHastalıkTakipSistemi.Wep.Models;
using HastaVeHastalıkTakipSistemi.Wep.Models.Donen;
using HastaVeHastalıkTakipSistemi.Wep.Models.Gelen;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace HastaVeHastalıkTakipSistemi.Wep.Controllers
{
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Giris(GirisDto girisDto)
        {
            if (girisDto.txtKullaniciAdi == "Salih" && girisDto.txtSifre=="Salih")
            {
                return RedirectToAction("Index", "AdminAnasayfa");
            }
            else 
            {
                return View(new GirisCevapDto() { 
                 Error="Kullanıcı Adı Şifresi Yanlış"
                });
            }
        }

    }
}
