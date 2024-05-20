using System.ComponentModel.DataAnnotations;

namespace LoanProject.Models;

public class LoanModel
{
    
    public int Id { get; set; }
    [Required(ErrorMessage = "Enter the name of the Receiver!")]
    public string Receiver { get; set; }
    [Required(ErrorMessage = "Enter the name of the Supplier!")]
    public string Supplier { get; set; }
    [Required(ErrorMessage = "Enter the name of the Book!")]
    public string BorrowedBook { get; set; }
    public DateTime LastBorrowDate { get; set; } = DateTime.Now;
}
