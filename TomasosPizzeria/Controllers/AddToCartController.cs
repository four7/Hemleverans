using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TomasosPizzeria.Models;
using TomasosPizzeria.ViewModel;

namespace TomasosPizzeria.Controllers
{
    public class AddToCartController : Controller
    {
        private TomasosContext _context;
        public AddToCartController(TomasosContext context)
        {
            _context = context;
        }
        public IActionResult Add()
        {
            var listdata = new MenuViewModel();

            listdata.matTypLista = _context.MatrattTyp.ToList();
            listdata.produktLista = _context.Produkt.ToList();
            listdata.matrattLista = _context.Matratt.ToList();

            return View(listdata);
        }
    }
}