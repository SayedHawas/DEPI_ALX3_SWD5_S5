using Microsoft.AspNetCore.Mvc;

namespace Day2Core8WebAPI17Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemosController : ControllerBase
    {

        private List<string> Names = new List<string>() { "Ahmed", "Mohamed", "Ali", "Mariem" };

        //https://localhost:7100/api/Demos
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Names;
        }
        //https://localhost:7100/api/Demos/1
        [HttpGet("{id:int}")]
        //[Route("{id}")]
        public string GetByID(int id)
        {
            return Names[id];
        }
        //https://localhost:7100/api/Demos/ahmed
        [HttpGet("{name:alpha}")]
        public string GetByName(string name)
        {
            return Names.FirstOrDefault(n => n == name);
        }

        [HttpGet("/api/getName/{name}")]
        public string GetByNameNew(string name)
        {
            return Names.FirstOrDefault(n => n == name);
        }
    }
}
