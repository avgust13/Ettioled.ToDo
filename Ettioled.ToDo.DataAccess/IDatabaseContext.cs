using Ettioled.ToDo.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ettioled.ToDo.DataAccess
{
    public interface IDatabaseContext
    {
        DbSet<ToDoRecord> ToDos { get; set; }
    }
}
