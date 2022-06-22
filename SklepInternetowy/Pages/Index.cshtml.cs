using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private int _wartosc = 13;
        private int innaZmienna;

        public int Wartosc
        {
            get
            {
                return _wartosc;
            }
            set => _wartosc =  (value > -1) ?  value : 0;
        }

        protected int Konto { get;  }

        /*public void setWartosc(int w) { 
            if (w > 15) 
                _wartosc = -1; 
            else
                _wartosc = w;  
        }

        public int getWartosc() { return (_wartosc<0) ? 0 : _wartosc; }*/

        public Models.Basket Basket { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Konto = 13;
        }

        public void OnGet()
        {
            Basket = new Models.Basket();
            Basket.ID = 12;
           // Console.WriteLine(Basket.ID);

        }

        public string DodajTekst()
        {
            return DodajTekst(0);
        }

        public string DodajTekst(int v)
        {
            return "<p>Tekst z funkcji"+ v +"</p>";
        }
    }
}
