using Common;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace To_Do_list.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        // GET: api/<TodoController>
        [HttpGet]
        public IEnumerable<Common.Todo> Get()
        {
            return FakeDataBase.TodoList;
        }

        // POST api/<TodoController>
        [HttpPost]
        public void Post([FromBody] Common.Todo todo)
        {
            Todo.Services.Create(todo);
        }

        // PUT api/<TodoController>/5
        [HttpPut]
        public void Put([FromBody] Common.Todo todo)
        {
            Todo.Services.Update(todo);
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Todo.Services.Delete(id);
        }
    }
}
