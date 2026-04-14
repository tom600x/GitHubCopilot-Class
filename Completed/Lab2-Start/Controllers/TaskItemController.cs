using CopilotDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CopilotDemo.Controllers
{
    public class TaskItemController : Controller
    {
        private static readonly List<TaskItem> Tasks =
        [
            new TaskItem
            {
                Id = 1,
                Title = "Set up Copilot lab",
                Description = "Confirm project runs and chat is enabled.",
                DueDate = DateTime.Today.AddDays(1),
                IsCompleted = false
            },
            new TaskItem
            {
                Id = 2,
                Title = "Practice inline completions",
                Description = "Complete model and controller exercises.",
                DueDate = DateTime.Today.AddDays(2),
                IsCompleted = false
            }
        ];

        public IActionResult Index()
        {
            return View(Tasks.OrderBy(t => t.IsCompleted).ThenBy(t => t.DueDate).ToList());
        }

        public IActionResult Details(int id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id);
            return task is null ? NotFound() : View(task);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new TaskItem { DueDate = DateTime.Today });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TaskItem taskItem)
        {
            if (!ModelState.IsValid)
            {
                return View(taskItem);
            }

            taskItem.Id = Tasks.Count == 0 ? 1 : Tasks.Max(t => t.Id) + 1;
            taskItem.CreatedDate = DateTime.UtcNow;
            Tasks.Add(taskItem);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id);
            return task is null ? NotFound() : View(task);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TaskItem taskItem)
        {
            if (id != taskItem.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(taskItem);
            }

            var existing = Tasks.FirstOrDefault(t => t.Id == id);
            if (existing is null)
            {
                return NotFound();
            }

            existing.Title = taskItem.Title;
            existing.Description = taskItem.Description;
            existing.DueDate = taskItem.DueDate;
            existing.IsCompleted = taskItem.IsCompleted;

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id);
            return task is null ? NotFound() : View(task);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id);
            if (task is not null)
            {
                Tasks.Remove(task);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
