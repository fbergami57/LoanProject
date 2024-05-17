using LoanProject.Data;
using LoanProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoanProject.Controllers;
public class LoanController : Controller
{
    readonly private ApplicationDbContext _db;
    public LoanController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        IEnumerable<LoanModel> loans = _db.Loans;
        return View(loans);
    }
}
