using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Entities.DTOs
{
    public class TaskAdd
    {
        public string Title { get; set; }
        public string DataAccess { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}