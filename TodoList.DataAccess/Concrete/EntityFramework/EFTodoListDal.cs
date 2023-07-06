using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Core.DataAccess.EntityFreamwork;
using TodoList.DataAccess.Abstract;
using TodoList.Entities.Concrete;

namespace TodoList.DataAccess.Concrete.EntityFramework
{
    public class EFTodoListDal : EfRepositoryBase<TaskList, AppDbContext>, ITodoListDal
    {
        
    }
}