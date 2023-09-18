namespace API.Entities;

public class Feedback
{
    public int Id { get; set; }
    public int TrainingId { get; set; } // Foreign key to Training
    public string TraineeName { get; set; }
    public string FeedbackDetails { get; set; }
    public DateTime FeedbackDate { get; set; }
    // Add other feedback-related properties
}