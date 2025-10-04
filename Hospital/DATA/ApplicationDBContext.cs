using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.DATA
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Doctor> doctors {  get; set; }
        public DbSet<Specialization> specializations { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<Patient> patients { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=HospitalDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Specialization>().HasData(
                new Specialization { Id = 1, Name = "Cardiology" },
                new Specialization { Id = 2, Name = "Dermatology" },
                new Specialization { Id = 3, Name = "Neurology" },
                new Specialization { Id = 4, Name = "Pediatrics" },
                new Specialization { Id = 5, Name = "Orthopedics" },
                new Specialization { Id = 6, Name = "General Surgery" }
            );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { DoctorId = 1, Name = "Dr. John Smith", Phone = "01000000001", SpecializationId = 1, ImagePath = "doctor1.jpg" },
                new Doctor { DoctorId = 2, Name = "Dr. Sarah Johnson", Phone = "01000000002", SpecializationId = 2, ImagePath = "doctor2.jpg" },
                new Doctor { DoctorId = 3, Name = "Dr. Emily Davis", Phone = "01000000003", SpecializationId = 3, ImagePath = "doctor3.jpg" },
                new Doctor { DoctorId = 4, Name = "Dr. Michael Brown", Phone = "01000000004", SpecializationId = 4, ImagePath = "doctor4.jpg" },
                new Doctor { DoctorId = 5, Name = "Dr. Olivia Wilson", Phone = "01000000005", SpecializationId = 5, ImagePath = "doctor5.jpg" },
                new Doctor { DoctorId = 6, Name = "Dr. David Miller", Phone = "01000000006", SpecializationId = 6, ImagePath = "doctor6.jpg" }
            );
        }

    }

}
