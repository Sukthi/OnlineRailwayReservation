using Microsoft.EntityFrameworkCore;
using OnlineRailwayReservation.Models;

namespace RailwayReservation.Models
{


    public class RailwayReservationContext : DbContext
    {
        public RailwayReservationContext(DbContextOptions<RailwayReservationContext> options) : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<PassengerDetails> Passengers { get; set; }
        public DbSet<TrainDetails> Trains { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Payment> Payment { get; set; }


        public object PassengerDetails { get; internal set; }
        public object Users { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.PassengerDetails)
                .WithMany()
                .HasForeignKey(r => r.PassengerId);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.TrainDetails)
                .WithMany()
                .HasForeignKey(r => r.TrainId);


            modelBuilder.Entity<PassengerDetails>()
             .HasKey(p => p.PassengerId);

            modelBuilder.Entity<TrainDetails>()
             .HasKey(t => t.TrainId);


            base.OnModelCreating(modelBuilder);
        }
    }
}