namespace Hospital.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;

        public int PatientId { get; set; }
        public Patient Patient { get; set; } = null!;
    }
}
