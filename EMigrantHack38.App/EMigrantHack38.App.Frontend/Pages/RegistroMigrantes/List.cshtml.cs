using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using EMigrantHack38.App.Dominio;
using EMigrantHack38.App.Persistencia;

namespace EMigrantHack38.App.Pages
{
    public class ListModel : PageModel
    {
       private readonly IRepositorioMigrante _repoMigrante;
        public Migrante migrante {get; set;}

        public ListModel(IRepositorioMigrante repoMigrante)
        {
            _repoMigrante = repoMigrante;
        }
        public void OnGet()
        {
            migrante = new Migrante();
        }
        public IActionResult OnPost(Migrante migrante)
        {
            if (ModelState.IsValid)
            {
                _repoMigrante.AddMigrante(migrante);
                return RedirectToPage("Index1");
            } else
            {
                return Page();
            }
        }
    }
}
