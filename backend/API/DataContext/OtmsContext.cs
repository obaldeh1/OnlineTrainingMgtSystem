using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.DataContext
{
    public class OtmsContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public OtmsContext(DbContextOptions<OtmsContext> options) : base(options)
        {

        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Expense>()
        //         .HasKey(e => e.ExpenseId); 
        // }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<GuestSpeaker> GuestSpeakers { get; set; }
        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}