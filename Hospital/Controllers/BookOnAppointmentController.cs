using Hospital.DATA;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Controllers
{
    public class AppointmentController : Controller
    {
        ApplicationDBContext _dbcontext = new ApplicationDBContext();
        [HttpGet]
        public IActionResult Book(string searchName, string searchSpecialty)
        {
            var doctors = _dbcontext.doctors
                .Include(d => d.Specialization)
                .AsQueryable();

           
            if (!string.IsNullOrEmpty(searchName))
            {
                doctors = doctors.Where(d => d.Name.Contains(searchName));
            }

            if (!string.IsNullOrEmpty(searchSpecialty))
            {
                doctors = doctors.Where(d => d.Specialization.Name.Contains(searchSpecialty));
            }

            return View(doctors.ToList());
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            var dot = _dbcontext.doctors.FirstOrDefault(e => e.DoctorId == id);
            return View(dot);
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
           
            var dayOfWeek = appointment.Date.DayOfWeek;
            if (dayOfWeek == DayOfWeek.Friday || dayOfWeek == DayOfWeek.Saturday)
            {
                ModelState.AddModelError("", "Doctor is only available from Sunday to Thursday.");
                return View(appointment);
            }

  
            var isTaken = _dbcontext.appointments.Any(a =>
                a.DoctorId == appointment.DoctorId &&
                a.Date == appointment.Date &&
                a.Time == appointment.Time);

            if (isTaken)
            {
                ModelState.AddModelError("", "This appointment slot is already booked.");
                return View(appointment);
            }

           
            _dbcontext.appointments.Add(appointment);
            _dbcontext.SaveChanges();

            return RedirectToAction("Reservations");
        }

    }
}
