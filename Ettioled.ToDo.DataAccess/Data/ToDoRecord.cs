using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ettioled.ToDo.DataAccess.Data
{
    public class ToDoRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ToDoId { get; set; }

        [Required]
        public string UserId { get; set; }

        public bool IsDone { get; set; }

        public string Description { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
