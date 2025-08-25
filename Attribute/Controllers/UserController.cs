using Microsoft.AspNetCore.Mvc;

namespace Attribute_Routing.Controllers
{
    
    public class UserController : Controller
    {
        [Route("")]
        [Route("Index")]
       
        public IActionResult Index()
        {
            return View();
        }

        [Route("Users/Details/{id}")]
        public int getId(int id)
        {
            return id;
        }
        
        [Route("Users/Deta/{name?}")]
       public string getName(string name)
        {
            return string.IsNullOrEmpty(name) ? "Invalid user" : name;
        }
    }
}
