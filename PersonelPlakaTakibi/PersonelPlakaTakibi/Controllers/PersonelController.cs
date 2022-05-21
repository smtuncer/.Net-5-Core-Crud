using Microsoft.AspNetCore.Mvc;
using PersonelPlakaTakibi.Models;
using System.Linq;

namespace PersonelPlakaTakibi.Controllers
{
    public class PersonelController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            var personelBilgi = db.Personels.ToList();
            return View(personelBilgi);
        }
        [HttpGet]
        public IActionResult Ekle()
        {            
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Personel p)
        {
            db.Personels.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Personel");
        }
        [HttpGet]
        public IActionResult Sil(int id)
        {
            var silinecekPersonel = db.Personels.FirstOrDefault(x => x.PersonelId == id);
            return View(silinecekPersonel);
        }
        [HttpPost]
        public IActionResult Sil(Personel p)
        {
            db.Personels.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Personel");
        }
        [HttpGet]
        public IActionResult Güncelle(int id)
        {
            var güncellenecekPersonel = db.Personels.FirstOrDefault(x => x.PersonelId == id);
            return View(güncellenecekPersonel);
        }
        [HttpPost]
        public IActionResult Güncelle(Personel p)
        {
            db.Personels.Update(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Personel");
        }
    }
}
