using Microsoft.AspNetCore.Mvc;
using Web_Projeto_integrado.Data;
using Web_Projeto_integrado.Models;

namespace Web_Projeto_integrado.Controllers
{
    public class EmprestimosController : Controller
    {
        readonly private ApplicationDbContext _db;

        public EmprestimosController(ApplicationDbContext db) 
        { 
          _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos;
            return View(emprestimos);
        }
    }
}
