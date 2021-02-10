using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest_TESS.Models;

namespace WebTest_TESS.Controllers
{
    public class TasksController : Controller
    {

        private readonly ApplicationDBContext _dBase;
        public IEnumerable<Tasks> tasksList { get; set; }
        public Tasks singleTask { get; set;  }

        public TasksController(ApplicationDBContext dBase)
        {
            _dBase = dBase;
        }

        public async Task<IActionResult> IndexAsync()
        {
            tasksList = await _dBase.Tasks.ToListAsync();
            return View(tasksList);
        }

        public IActionResult Create(string data) {
            ViewBag.Success = data;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tasks taskObject)
        {

            if (ModelState.IsValid)
            {
                await _dBase.AddAsync(taskObject);
                await _dBase.SaveChangesAsync();
                return RedirectToAction("Create", new { data="Success Saved"});
            }
            else
            {
                return View();
            }

        }

        public async Task<IActionResult> Edit(int id)
        {
            singleTask = await _dBase.Tasks.FindAsync(id);
            if (singleTask == null)
                return NotFound();
            return View(singleTask);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Tasks taskObject)
        {
            if (ModelState.IsValid)
            {
                singleTask = await _dBase.Tasks.FindAsync(taskObject.pk_Task);
                singleTask.name_Task = taskObject.name_Task;
                singleTask.date_Task = taskObject.date_Task;
                singleTask.complete_Task = taskObject.complete_Task;
                await _dBase.SaveChangesAsync();

                tasksList = await _dBase.Tasks.ToListAsync();

                return View("Index", tasksList);
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            singleTask = await _dBase.Tasks.FindAsync(id);
            if (singleTask == null)
                return NotFound();

            _dBase.Remove(singleTask);
            await _dBase.SaveChangesAsync();

            tasksList = await _dBase.Tasks.ToListAsync();

            return View("Index", tasksList);
        }
    }
}
