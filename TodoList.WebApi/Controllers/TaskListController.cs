using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoList.Business.Abstract;
using TodoList.Entities.DTOs;

namespace TodoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TaskListController : ControllerBase
    {
        private readonly ITaskListService _taskListService;

        public TaskListController(ITaskListService taskListService)
        {
            _taskListService = taskListService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            try
            {
                var result = _taskListService.GetAllTasks();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

        }

        [HttpPost("add")]
        public IActionResult AddTask(TaskAddDTo task)
        {
            try
            {
                _taskListService.AddToDolIst(task);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }

        }
    }
}