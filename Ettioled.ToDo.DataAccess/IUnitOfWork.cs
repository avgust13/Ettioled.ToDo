using Ettioled.ToDo.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ettioled.ToDo.DataAccess
{
    public interface IUnitOfWork
    {
        IToDoRepository ToDo { get; }

        void Complete();
    }
}
