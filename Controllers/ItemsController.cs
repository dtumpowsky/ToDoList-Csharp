using Mircosoft.AspNetCore.Mvc;
using ToDoList.MOdels;

namespace ToDoList.Controllers
{
    public class ItemsCOntroller : Controllers{

        [HttpGet("/items")]
        public ActionResult Index()
        {
            Item newItem = new Item(Request.Query["new-item"]);
            return View(newItem);
        }

        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
    }
}
