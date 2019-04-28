using Ettioled.ToDo.Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ettioled.ToDo.Business.Services
{
    public interface IToDoService
    {
        void Add(ToDoData data);
        bool Delete(int id, string userId);
        void Update(ToDoData todo);
        IEnumerable<ToDoData> GetUserToDoList(string userId);
        ToDoData GetById(int id, string userId);
    }
}
