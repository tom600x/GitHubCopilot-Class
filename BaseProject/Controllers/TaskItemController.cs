using Microsoft.AspNetCore.Mvc;
using CopilotDemo.Models;

namespace CopilotDemo.Controllers
{
    public class TaskItemController : Controller
    {
        // GET: TaskItem
        public IActionResult Index()
        {
            return View();
        }
    }
}
