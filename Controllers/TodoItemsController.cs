using Microsoft.AspNetCore.Mvc;
using TodoListDemo.Data;
using TodoListDemo.Data.Models;

namespace TodoListDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TodoItemsController : ControllerBase
    {
        private readonly TodoDbContext _context;

        public TodoItemsController(TodoDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetToDoById(int id) 
        { 
            var todo = await _context.TodoItems.FindAsync(id);

            if(todo == null)
            {
                return NotFound();
            }

            return Ok(todo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDoById(int id)
        {
            var todo = await _context.TodoItems.FindAsync(id);

            if(todo == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todo);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateToDo(int id, [FromBody] TodoItem updatedTodo)
        {
            if (id != updatedTodo.Id)
                return BadRequest("ID in URL and in request body do not match");

            var todo = await _context.TodoItems.FindAsync(id);

            if (todo == null)
            {
                return NotFound();
            }

            todo.Title = updatedTodo.Title;
            todo.Description = updatedTodo.Description;
            todo.IsCompleted = updatedTodo.IsCompleted;

            await _context.SaveChangesAsync();

            return Ok(todo);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTodoItem([FromBody] TodoItem newTodo)
        {
            _context.TodoItems.Add(newTodo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetToDoById), new { id = newTodo.Id }, newTodo);
        }

    }
}
