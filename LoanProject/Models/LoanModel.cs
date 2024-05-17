namespace LoanProject.Models;

public class LoanModel
{
    public int Id { get; set; }
    public string Receiver { get; set; }
    public string Supplier { get; set; }
    public string BorrowedBook { get; set; }
    public DateTime LastBorrowDate { get; set; } = DateTime.Now;
}
