namespace Hospital.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int SpecializationId { get; set; }

        public Specialization Specialization { get; set; } = null!;

        public string ImagePath { get; set; } = null!;
        public List<Appointment> Appointments { get; set; } = new();
    }
}
