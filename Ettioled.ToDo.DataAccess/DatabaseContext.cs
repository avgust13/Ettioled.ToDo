using Ettioled.ToDo.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ettioled.ToDo.DataAccess
{

    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DbSet<ToDoRecord> ToDos { get; set; }


        public DatabaseContext()
            : base("DefaultConnection")
        {
        }

        public static DatabaseContext Create()
        {
            return new DatabaseContext();
        }
    }
}
