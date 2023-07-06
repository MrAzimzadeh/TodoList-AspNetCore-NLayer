using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoList.Entities.Concrete;

namespace TodoList.DataAccess.Concrete.EntityFramework
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Server=127.0.0.1,1433;Database=ToDoListDB; User Id=sa; Password=Password@12345; TrustServerCertificate=True;");
        }


        public DbSet<TaskList> taskLists { get; set; }   


        /* 

                ?_____?
                * ||| *
                ! <*> !
                - ||| -
                -_-*-_-
                  /|\
                 /-|-\    
            *   /--|--\   *
        !  <_> /<->|<->\ <_>  !
            *  \---|---/  *
                \--|--/
                 \-|-/
                  \_/
                   *
                  /|\
                ?=====?
              *-*_____*-*

         */


    }
}
