using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pomotask.Models;

namespace pomotask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {

        public TaskController() { }
        public List<TaskModel> Tasks = new List<TaskModel>(){

            new TaskModel(){
                id = 1,
                title = "teste"
            },
              new TaskModel(){
                id = 2,
                title = "teste2"
            }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Tasks);
        }

        [HttpGet("{id: id}")]
        public IActionResult GetById(int id)
        {
            var task = Tasks.FirstOrDefault(a => a.id == id);
            if (task == null) return BadRequest("não encontrado");

            return Ok(task);
        }

        [HttpPost]
        public IActionResult Post(TaskModel title)
        {


            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TaskModel title)
        {
           

            return Ok();
        }


        [HttpPatch("{id}")]
        public IActionResult Patch( int id, TaskModel title)
        {


            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {


            return Ok();
        }


    };
};