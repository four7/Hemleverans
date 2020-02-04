using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TomasosPizzeria.Models;
using TomasosPizzeria.ViewModel;

namespace TomasosPizzeria.Controllers
{
    public class MenuController : Controller
    {
        private TomasosContext _context;
        public MenuController(TomasosContext context)
        {
            _context = context;
        }
        public IActionResult MenuChoicePizza()
        {
            int pizza = 1;

            var listdata = new MenuViewModel();

            var ratt = (from s in _context.Matratt
                        select s).ToList();
            var ratt1 = (from m in _context.MatrattProdukt
                         join p in _context.Produkt on m.ProduktId equals p.ProduktId
                         select m).ToList();


            ratt = ratt.Where(s => s.MatrattTyp == pizza).ToList();
            

            listdata.matrattLista = _context.Matratt.ToList();
            listdata.produktLista = _context.Produkt.ToList();

            listdata.matrattLista = ratt;
            listdata.produkt.MatrattProdukt = ratt1;
            
            return View(listdata);
        }
        public IActionResult MenuChoicePasta()
        {
            int pasta = 2;

            var listdata = new MenuViewModel();

            var ratt = (from s in _context.Matratt
                        select s).ToList();
            var ratt1 = (from m in _context.MatrattProdukt
                         join p in _context.Produkt on m.ProduktId equals p.ProduktId
                         select m).ToList();

            ratt = ratt.Where(s => s.MatrattTyp == pasta).ToList();


            listdata.matrattLista = _context.Matratt.ToList();
            listdata.produktLista = _context.Produkt.ToList();

            listdata.matrattLista = ratt;
            listdata.produkt.MatrattProdukt = ratt1;

            return View(listdata);
        }
        public IActionResult MenuChoiceSalad()
        {
            int sallad = 3;

            var listdata = new MenuViewModel();

            var ratt = (from s in _context.Matratt
                        select s).ToList();
            var ratt1 = (from m in _context.MatrattProdukt
                         join p in _context.Produkt on m.ProduktId equals p.ProduktId
                         select m).ToList();

            ratt = ratt.Where(s => s.MatrattTyp == sallad).ToList();


            listdata.matrattLista = _context.Matratt.ToList();
            listdata.produktLista = _context.Produkt.ToList();

            listdata.matrattLista = ratt;
            listdata.produkt.MatrattProdukt = ratt1;

            return View(listdata);
        }
    }
}