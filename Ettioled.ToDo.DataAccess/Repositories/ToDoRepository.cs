using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ettioled.ToDo.DataAccess.Data;

namespace Ettioled.ToDo.DataAccess.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly IDatabaseContext _context;

        public ToDoRepository(IDatabaseContext context)
        {
            _context = context;
        }

        public void Add(ToDoRecord todo)
        {
            _context.ToDos.Add(todo);
        }

        public IEnumerable<ToDoRecord> GetAllByUserId(string userId)
        {
            return _context.ToDos.Where(e => e.UserId.Equals(userId)).ToList();
        }

        public ToDoRecord GetByIdAndUserId(int id, string userId)
        {
            return _context.ToDos.FirstOrDefault(e => e.ToDoId.Equals(id));
        }

        public void Remove(ToDoRecord toDoRecord)
        {
            _context.ToDos.Remove(toDoRecord);
        }
    }
}
