using Ettioled.ToDo.Business.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ettioled.ToDo.Web.Models
{
    public class ToDosViewModel:Collection<ToDoData>
    {
    }
}