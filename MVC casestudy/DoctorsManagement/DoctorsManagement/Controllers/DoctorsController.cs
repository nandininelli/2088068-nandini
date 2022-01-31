using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DoctorsManagement.Models;
using Microsoft.EntityFrameworkCore;


namespace DoctorsManagement.Controllers
{
    public class DoctorsController : Controller
    {

        private readonly DoctorsDbContext context;

        private readonly IRepository<DoctorsInfo> doctorRepository;
        public DoctorsController(DoctorsDbContext context)
        {
            this.context = context;
            this.doctorRepository = new GenericRepository<DoctorsInfo>(this.context);
        }
        public async Task<IActionResult> Index()
        {

            var doctors = await doctorRepository.GetAsync();
      
            return View(doctors);
           
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DoctorsInfo doctor)
        {
            if (!ModelState.IsValid)
                return View(doctor);

            doctorRepository.Add(doctor);
            await doctorRepository.SaveAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var doctor = await doctorRepository.GetByIdAsync(id);

            if (doctor == null) return NotFound();

            return View(doctor);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var doctor = await doctorRepository.GetByIdAsync(id);

            if (doctor == null) return NotFound();

            return View(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(DoctorsInfo doctor)
        {
            if (!ModelState.IsValid)
                return View(doctor);

            doctorRepository.Update(doctor);
            await doctorRepository.SaveAsync();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var doctor = await doctorRepository.GetByIdAsync(id);

            if (doctor == null) return NotFound();

            return View(doctor);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctor = await doctorRepository.GetByIdAsync(id);
            doctorRepository.Delete(doctor);
            await doctorRepository.SaveAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Search()
        {
            throw new NotImplementedException();
        }
    }
}
   
