using Hospital.DATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Controllers
{
    public class ReservationsController : Controller
    {
        ApplicationDBContext _dbcontext = new ApplicationDBContext();
        public IActionResult AllAppointments()
        {
            var reservations = _dbcontext.appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .ToList();

            return View(reservations);
        }
    }
}
