using CRD_Pro.Data;
using CRD_Pro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRD_Pro.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _Context;
        public StudentController(ApplicationDbContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            var Data = _Context.Students.ToList();
            return View(Data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student S)
        {
            _Context.Students.Add(S);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var Data = _Context.Students.Where(x => x.Id == Id).FirstOrDefault();
            return View(Data);
        }
        [HttpPost]
        public IActionResult Edit(Student Student)
        {
            _Context.Students.Update(Student);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int Id)
        {
            var Data = _Context.Students.Where(x => x.Id == Id).FirstOrDefault();
            return View(Data);
        }
        [HttpGet]
        public IActionResult Delete(Student student)

        {
            //var Data=  _Context.Students.Where(x => x.Id == Id).FirstOrDefault();
            var Data = _Context.Students.Remove(student);
            //  _Context.Students.Remove();
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
