using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.web.Data;
using StudentPortal.web.Models;
using StudentPortal.web.Models.Entities;

namespace StudentPortal.web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDBContext _dBContext;

        public StudentsController(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            // Entity properties match lowercase names in Student entity
            var student = new Student
            {
                id = Guid.NewGuid(),
                name = viewModel.name,
                email = viewModel.email,
                phone = viewModel.phone,
                subcribed = viewModel.subcribed
            };

            await _dBContext.Students.AddAsync(student);
            await _dBContext.SaveChangesAsync();

            return RedirectToAction("List", "Students");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var studentsList = await _dBContext.Students.ToListAsync();
            return View(studentsList);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await _dBContext.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student = await _dBContext.Students.FindAsync(viewModel.id);

            if (student is not null)
            {
                student.name = viewModel.name;
                student.email = viewModel.email;
                student.phone = viewModel.phone;
                student.subcribed = viewModel.subcribed;

                await _dBContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Students");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Student viewModel)
        {
            var student = await _dBContext.Students.FindAsync(viewModel.id);

            if (student is not null)
            {
                _dBContext.Students.Remove(student);
                await _dBContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Students");
        }
    }
}