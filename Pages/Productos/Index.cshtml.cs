using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Pages.Productos
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Productos { get; set; }

        public async Task OnGetAsync()
        {
            Productos = await _context.Productos.ToListAsync();
        }
    }
}
