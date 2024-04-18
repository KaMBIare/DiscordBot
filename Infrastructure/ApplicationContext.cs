using Domain;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure;

public class ApplicationContext : DbContext
{
    public DbSet<Reservation> Reservations { get; set; }

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //подключаемся к бд
        optionsBuilder.UseSqlite("Data Source=ReservationsDB.db");
        
    }
   
}