using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Core.Entities.Abstract;

namespace TodoList.Core.DataAccess
{
    public  interface IRepositoryBase<TEntity>
        where TEntity : IEntity , new()
    {

    }
}
