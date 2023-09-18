namespace API.Entities;

public class Visit
{
    public int Id { get; set; }
    public int TrainingId { get; set; } // Foreign key to Training
    public string VisitorName { get; set; }
    public DateTime VisitDate { get; set; }
    public string Purpose { get; set; }
    // Add other visit-related properties
}