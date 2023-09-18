namespace API.Entities;

public class Bill
{
    public int Id { get; set; }
    public int TrainingId { get; set; } // Foreign key to Training
    public decimal Amount { get; set; }
    public DateTime BillDate { get; set; }
    public string Description { get; set; }
    // Add other bill-related properties
}