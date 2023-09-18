using API.DataContext;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/trainings")]
public class TrainingsController : Controller
{
    private readonly OtmsContext _context;

    public TrainingsController(OtmsContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public IActionResult GetAllTrainings()
    {
        return Ok(_context.Trainings.ToList());
    }
    
    [HttpGet("{id}")]
    public IActionResult GetTrainingById(int id)
    {
        var training = _context.Trainings.FirstOrDefault(x => x.Id == id);
        if (training == null)
        {
            return NotFound();
        }
        return Ok(training);
    }
    
    [HttpPost]
    public IActionResult CreateTraining([FromBody] Training training)
    {
        // Add validation logic if needed
        // training.Id = _trainings.Count + 1;
        // _trainings.Add(training);
        training.TrainingName = training.TrainingName;
        
        return CreatedAtAction(nameof(GetTrainingById), new { id = training.Id }, training);
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateTraining(int id, [FromBody] Training updatedTraining)
    {
        var existingTraining = _context.Trainings.FirstOrDefault(t => t.Id == id);
        if (existingTraining == null)
        {
            return NotFound();
        }

        // Update properties of existingTraining with values from updatedTraining
        existingTraining.TrainingName = updatedTraining.TrainingName;
        existingTraining.StartDate = updatedTraining.StartDate;
        existingTraining.EndDate = updatedTraining.EndDate;
        existingTraining.Description = updatedTraining.Description;
        existingTraining.Cost = updatedTraining.Cost;
        existingTraining.IsActive = updatedTraining.IsActive;

        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteTraining(int id)
    {
        var training = _context.Trainings.FirstOrDefault(t => t.Id == id);
        if (training == null)
        {
            return NotFound();
        }

        _context.Trainings.Remove(training);
        return NoContent();
    }


}