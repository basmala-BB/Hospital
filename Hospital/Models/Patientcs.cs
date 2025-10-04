namespace Hospital.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string Diagnosis { get; set; } = null!;

        public List<Appointment> Appointments { get; set; } = new();
    }
}
