using ITS_System.Data;
using ITS_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlexAppealFitness.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public BookingController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var classSchedules = from c in _context.Schedule
                                 select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                classSchedules = classSchedules.Where(s => s.Instructor.Email.Contains(searchString) || s.DateTime.ToString().Contains(searchString));
            }

            return View(await classSchedules.Include("Instructor").Include("Room").Include("Attendees").OrderBy(s => s.DateTime).ToListAsync());
        }

        public async Task<IActionResult> Book(int Id)
        {
            var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (currentUser == null)
            {
                return NotFound();
            }

            Booking book = new Booking();

            book.ClassId = Id;
            book.AttendeeId = currentUser.Id;
            book.TimeStamp = DateTime.Now;
            book.Status = Enums.BookingStatus.Active;
            book.Attendee = currentUser;

            var currentClass = await _context.Schedule.FindAsync(Id);
         
            if (currentClass == null)
            {
                return NotFound();
            }


            bool doubleBook = currentClass.Attendees.Any(a => a.AttendeeId == currentUser.Id);
           
            if (doubleBook)
            {
                return RedirectToAction("Index", "Bookings");
            }

            book.Class = currentClass;

            currentClass.Attendees.Add(book);
            currentClass.AvailableSpaces = currentClass.MaxNumbersOfBooking - currentClass.Attendees.Count();
            _context.Schedule.Update(currentClass);

            await _context.SaveChangesAsync();
            //redirect to Bookings Controller
            return RedirectToAction("Index", "Bookings");

        }


    }
}
