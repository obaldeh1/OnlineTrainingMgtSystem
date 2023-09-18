namespace API.Entities;

public class Trainee
{
    public int Id { get; set; }
    public string TrainingName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }
    public decimal Cost { get; set; }
    public bool IsActive { get; set; }
    // Add other training-related properties
}