using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class Expense
{
    [Key]
    public int ExpenseId { get; set; } // This is the primary key
    public string Description { get; set; }
    public decimal Amount { get; set; }
}