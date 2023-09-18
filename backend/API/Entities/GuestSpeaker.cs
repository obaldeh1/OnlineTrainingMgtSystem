namespace API.Entities;

public class GuestSpeaker
{
    public int Id { get; set; }
    public string SpeakerName { get; set; }
    public string Topic { get; set; }
    public DateTime LectureDate { get; set; }
    // Add other guest speaker-related properties
}