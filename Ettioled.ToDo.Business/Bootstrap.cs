using log4net;
using Ettioled.ToDo.Business.Services;
using Ettioled.ToDo.DataAccess;
using Ettioled.ToDo.DataAccess.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ettioled.ToDo.Business
{
    public class Bootstrap
    {
        public static void Start(Container container)
        {
            container.Register<IUnitOfWork, UnitOfWork>();
            container.Register<IToDoService, ToDoService>();
            container.Register<IToDoRepository, ToDoRepository>();
        }
    }
}