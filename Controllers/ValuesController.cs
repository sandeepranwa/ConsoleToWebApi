using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    
    [ApiController]
    [Route("[controller]/[action]")] //This is base route for access all method through method name and controller name
    public class ValuesController : ControllerBase
    {
        [Route("~/Api/Get-All")]// using thi "~" tild symbol we cannot bhi access this route through base route
        [Route("~/GetAll")] 
        //[Route("[Controller]/[action]")]
        //[Route("[action]/[Controller]")] //You can use route this type order but only condion is unique URl

        public string getall()
        {
            return "Here is the all info...";
        }

        //[Route("Api/Get-All-Author")]
        public string getallAuthor()
        {
            return "Here is the all Author info...";
        }

        //[Route("book/{id}/author/{authorId}")]
        //[Route("[Controller]/[action]")]
        public string GetauthoraddresByid(int id, int authorId) 
        { 
            return "here is book id is " +id + " And " +authorId;
        }

        [Route("Search")]

        public string BySearch(int id, int authorid,string name,int price)
        {
            return "The book id is " +id+" and Author name are "+name+ " ,author id is "+authorid+ " also price is " +price;
        }
    }
}
