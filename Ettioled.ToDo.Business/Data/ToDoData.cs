using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ettioled.ToDo.Business.Data
{
    public class ToDoData
    {
        public int ToDoId { get; set; }

        public string UserId { get; set; }

        public bool IsDone { get; set; }

        public string Description { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
