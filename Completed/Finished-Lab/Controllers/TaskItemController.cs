using CopilotDemo.Models;
using CopilotDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CopilotDemo.Controllers
{
    public class TaskItemController(TaskItemService service) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var items = await service.GetAllAsync();
            return View(items);
        }

        public async Task<IActionResult> Details(int id)
        {
            var task = await service.GetByIdAsync(id);
            return task is null ? NotFound() : View(task);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new TaskItem { DueDate = DateTime.Today });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskItem taskItem)
        {
            if (!ModelState.IsValid)
            {
                return View(taskItem);
            }

            await service.AddAsync(taskItem);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var task = await service.GetByIdAsync(id);
            return task is null ? NotFound() : View(task);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TaskItem taskItem)
        {
            if (id != taskItem.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(taskItem);
            }

            var updated = await service.UpdateAsync(taskItem);
            return updated ? RedirectToAction(nameof(Index)) : NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var task = await service.GetByIdAsync(id);
            return task is null ? NotFound() : View(task);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
