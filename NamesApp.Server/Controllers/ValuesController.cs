using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NamesApp.Models;

namespace NamesApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<Person> Values { get; set; } = new List<Person>
        {
            new Person(){Id=1,Name="Amir"},
            new Person(){Id=2,Name="Ahmad"},
            new Person(){Id=3,Name="Ramadan"},
            new Person(){Id=4,Name="Gemmy"},
            new Person(){Id=5,Name="Amr"},
        };

        [HttpGet]
        public List<Person> Get()
        {
            return Values;
        }

        [HttpPost]
        public IActionResult Add(Person person)
        {
            if(Values.Any(it=> it.Name == person.Name))
            {
                return BadRequest("Name already exists");
            }
            Values.Add(person);
            return Ok(person);

        }

    }
}
