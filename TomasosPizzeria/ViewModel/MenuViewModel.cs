using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomasosPizzeria.Models;

namespace TomasosPizzeria.ViewModel
{
    public class MenuViewModel
    {
        public Bestallning bestallning { get; set; }
        public BestallningMatratt bestallningMat { get; set; }
        public Kund kund { get; set; }
        public Matratt matratt { get; set; }
        public MatrattProdukt matrattProd { get; set; }
        public MatrattTyp matrattTyp { get; set; }
        public Produkt produkt { get; set; }
        public List<TomasosContext> DBLista { get; set; } 
        public List<MatrattTyp> matTypLista { get; set; }
        public List<Produkt> produktLista { get; set; }
        public List<Matratt> matrattLista { get; set; }
        public List<MenuViewModel> menyLista { get; set; }
        public List<string> stringLista { get; set; }

        public MenuViewModel()
        {
            bestallning = new Bestallning();
            bestallningMat = new BestallningMatratt();
            kund = new Kund();
            matratt = new Matratt();
            matrattProd = new MatrattProdukt();
            matrattTyp = new MatrattTyp();
            produkt = new Produkt();
            DBLista = new List<TomasosContext>();
            matTypLista = new List<MatrattTyp>();
            produktLista = new List<Produkt>();
            matrattLista = new List<Matratt>();
            menyLista = new List<MenuViewModel>();
            stringLista = new List<string>();
        }
    }
}
