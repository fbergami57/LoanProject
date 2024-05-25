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

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        LoanModel loan = _db.Loans.FirstOrDefault(x => x.Id == id);

        if (loan == null) 
        {
            return NotFound();
        }

        return View(loan);
    }

    [HttpGet]
    public IActionResult Delete(int? id) 
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        LoanModel loan = _db.Loans.FirstOrDefault(x => x.Id == id);

        if (loan == null)
        {
            return NotFound();
        }

        return View(loan);
    }

    [HttpPost]
    public IActionResult Register(LoanModel loan)
    {
        if (ModelState.IsValid)
        {
            _db.Loans.Add(loan);
            _db.SaveChanges();

            TempData["SuccessMessage"] = "Record added succesfully!";

            return RedirectToAction("Index");
        }

        TempData["ErrorMessage"] = "Record not added!";

        return View();
    }

    [HttpPost]
    public IActionResult Edit(LoanModel loan)
    {
        if (ModelState.IsValid)
        {
            _db.Loans.Update(loan);
            _db.SaveChanges();

            TempData["SuccessMessage"] = "Editing completed successfully!";

            return RedirectToAction("Index");
        }

        TempData["ErrorMessage"] = "Record not Edited!";

        return View(loan);
    }

    [HttpPost]
    public IActionResult Delete(LoanModel loan) 
    {
        if (loan == null) 
        {
            return NotFound();
        }

        _db.Loans.Remove(loan);
        _db.SaveChanges();

        TempData["SuccessMessage"] = "Delete completed successfully!";

        return RedirectToAction("Index");   
    }
}
