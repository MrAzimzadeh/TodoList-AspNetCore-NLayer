using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Core.DataAccess;
using TodoList.Entities.Concrete;
namespace TodoList.DataAccess.Abstract
{
    public interface ITodoListDal : IRepositoryBase<TaskList>
    {
        
    }
}