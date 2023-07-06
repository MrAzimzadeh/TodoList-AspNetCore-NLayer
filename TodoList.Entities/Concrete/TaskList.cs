using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Core.Entities.Abstract;

namespace TodoList.Entities.Concrete
{
    public class TaskList : IEntity
    {
     public int Id { get; set; }   
     public string Title { get; set; }
     public string DataAccess { get; set; }
     public DateTime DeadLine { get; set; }
     public bool IsActive { get; set; }
     public bool IsDeleted { get; set; }
    }
}