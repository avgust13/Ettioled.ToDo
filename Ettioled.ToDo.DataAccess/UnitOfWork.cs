using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ettioled.ToDo.DataAccess.Repositories;

namespace Ettioled.ToDo.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        public IToDoRepository ToDo { get; private set; }

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            ToDo = new ToDoRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
