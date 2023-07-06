using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities.Concrete;
using TodoList.Entities.DTOs;

namespace TodoList.Business.Abstract
{
    public interface ITaskListService
    {
        void AddToDolIst(TaskAddDTo addTask);
        List<TaskListDTO> GetAllTasks();
    }
}