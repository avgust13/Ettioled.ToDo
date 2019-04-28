using Ettioled.ToDo.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ettioled.ToDo.DataAccess.Repositories
{
    public interface IToDoRepository
    {
        void Add(ToDoRecord todo);
        IEnumerable<ToDoRecord> GetAllByUserId(string userId);
        ToDoRecord GetByIdAndUserId(int id, string userId);
        void Remove(ToDoRecord todo);
    }
}
