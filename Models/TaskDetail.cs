using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDExcellent.Models
{
    [Table("TaskDetails")]
    public class TaskDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Create_by { get; set; }
        public int Status { get; set; }
        public string Category { get; set; }
        public string Performer { get; set; }
        public string Description { get; set; }
    }
}