using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using TodoList.Business.Abstract;
using TodoList.DataAccess.Abstract;
using TodoList.Entities.Concrete;
using TodoList.Entities.DTOs;

namespace TodoList.Business.Concrete
{
    public class TaskListManager : ITaskListService
    {
        private readonly ITodoListDal _todoListDal;
        private readonly IMapper _mapper;
        public TaskListManager(ITodoListDal todoListDal, IMapper mapper)
        {
            _todoListDal = todoListDal;
            _mapper = mapper;
        }

        public void AddToDolIst(TaskAddDTo addTask)
        {
            /*  uZUN   
            // TaskList taskList = new()
            // {
            //     DataAccess = addTask.DataAccess,
            //     DeadLine = addTask.DeadLine,
            //     IsActive = addTask.IsActive,
            //     IsDeleted = addTask.IsDeleted,
            //     Title = addTask.Title
            // };
            // _todoListDal.Add(taskList);
        */

            #region Mapper Vers 
            var mapper = _mapper.Map<TaskList>(addTask);
            _todoListDal.Add(mapper);
            #endregion
        }

        public List<TaskListDTO> GetAllTasks()
        {
            var tasks = _todoListDal.GetAll();
            // ! lITI PROFILE HISSESINE YAZMAGA EHTIYAC YOXDU 
            var mapper = _mapper.Map<List<TaskListDTO>>(tasks);
            return mapper;
        }
    }
}