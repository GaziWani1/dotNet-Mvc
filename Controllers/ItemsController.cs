using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Id = 1, Name = "key board" };
            return View(item);
        }
        public IActionResult Edit(int id)
        {
            return Content("Id =" + id);
        }
    }
}