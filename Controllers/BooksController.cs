using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        [Route("{id:int:min(2):max(10)}")] //Route Constraints ...min() , max()
        public string GetById(int id)
        {
            return "here id is " + id;
        }

        [Route("{id:minlength(3):maxlength(10):alpha}")] //MinLength() and MaxLength and Range(10,27) ....Alpha()
        public string GetByName(string id )
        {
            return "here id name is " + id;
        }
    }
}
