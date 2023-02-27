using Microsoft.EntityFrameworkCore;

namespace CodeFirstVenueBooking.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {

        }
        public DbSet<Payment> Payments { get; set; }

       
        public DbSet<Decoration> Decorations { get; set; }

        public DbSet<CustomerEventDetails> CustomerEventDetails { get; set; }
        public DbSet<Booking> Bookings { get; set; }

    }
}
