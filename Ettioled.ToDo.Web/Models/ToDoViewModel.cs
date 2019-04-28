using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ettioled.ToDo.Web.Models
{
    public class ToDoViewModel
    {
        [Required]
        [MaxLength(255)]
        [Display(Name = "Add new todo task")]
        public string Description { get; set; }

        public string UserId { get; set; }

    }
}