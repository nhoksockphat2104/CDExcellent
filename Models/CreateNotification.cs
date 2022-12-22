using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDExcellent.Models
{
    [Table("CreateNotifications")]
    public class CreateNotification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Staff { get; set; }
        public string Note { get; set; }
    }
}