using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.DataAccess.Repositories.IRepository;
using ToDoList.Models;

namespace ToDoListWeb.Controllers
{
    public class ToDoTaskController : Controller
    {
        private readonly IUnitOfWork _UnitOfWork;
        public ToDoTaskController(IUnitOfWork UnitOfWorkok)
        {

            _UnitOfWork = UnitOfWorkok;

        }
        public IActionResult Index()
        {
            List<ToDoTask> myToDoTaskS = _UnitOfWork.ToDoTask.GetAll().ToList();
            return View(myToDoTaskS);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ToDoTask obj)
        {
            if (ModelState.IsValid)
            {
                _UnitOfWork.ToDoTask.Add(obj);
                _UnitOfWork.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }
            ToDoTask myToDoTask = _UnitOfWork.ToDoTask.Get(u => u.Id == id);
            if (myToDoTask == null)
            {
                return NotFound();
            }
            return View(myToDoTask);
        }

        [HttpPost]
        public IActionResult Edit(ToDoTask obj)
        {
            if (ModelState.IsValid)
            {
                _UnitOfWork.ToDoTask.Update(obj);
                _UnitOfWork.Save();
                TempData["success"] = "ToDoTask edited successfully";
                return RedirectToAction("index");
            }
            return View(obj);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            ToDoTask myToDoTask = _UnitOfWork.ToDoTask.Get(u => u.Id == id);
            if (myToDoTask == null)
            {
                return NotFound();
            }
            return View(myToDoTask);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            ToDoTask myToDoTask = _UnitOfWork.ToDoTask.Get(u => u.Id == id);

            if (myToDoTask == null)
            {
                return NotFound();
            }
            _UnitOfWork.ToDoTask.Remove(myToDoTask);
            _UnitOfWork.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("index");


        }
    }
}
