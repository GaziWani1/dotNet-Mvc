using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            var item = new Item() { Id = 1 , Name = "Item One"};
            return View(item);
        }
    }
}