using ProjeTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeTest2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        List<kayitModel> kayitListe = new List<kayitModel> { 
            new kayitModel() {kayId=1,adsoyad="muhittin",tckimlik=21014583221},
            new kayitModel() {kayId=1,adsoyad="ayşe",tckimlik=21014583220},
            new kayitModel() {kayId=1,adsoyad="ali",tckimlik=21014583222},
            new kayitModel() {kayId=1,adsoyad="namık",tckimlik=21014583223},
            new kayitModel() {kayId=1,adsoyad="fadime",tckimlik=21014583224},

        }; 

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kayitlar()
        {
            return View(kayitListe);
        }

    }
}