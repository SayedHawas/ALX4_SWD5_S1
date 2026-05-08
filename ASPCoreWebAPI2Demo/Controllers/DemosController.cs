using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI2Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DemosController : ControllerBase
    {
        static List<string> names = new List<string> { "Sayed", "Ahmed", "Ali", "zayed" };

        //https://localhost:7080/api/demos
        [HttpGet]
        public List<string> Get()
        {
            return names;
            //return new List<string> { "Welcome", "Hello", "ASP.Net" };
        }
        //https://localhost:7080/api/demos/1
        [HttpGet("{id}")]
        //[Route("{id}")]
        public string GetById(int id)
        {
            if (id <= 0)
                return "Bad Request";
            if (id > names.Count)
                return "Not Found";

            return names[id - 1];
        }
        [HttpPost]
        public string Create(string name)
        {
            names.Add(name);
            return "Created Check Get";
        }
        [HttpPut("{id}")]
        public string Edit(int id, string newName)
        {
            if (id <= 0)
                return "Bad Request";
            if (id > names.Count)
                return "Not Found";
            // >>> code 

            return "Update Check List ";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            //Code 
            return "Delete Done Check List ";
        }
    }
}
