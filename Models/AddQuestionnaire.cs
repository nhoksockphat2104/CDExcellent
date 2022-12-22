using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CDExcellent.Models
{
    [Table("AddQuestionnaires")]
    public class AddQuestionnaire
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Status { get; set; }
    }
}