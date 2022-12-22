using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDExcellent.Models
{
    [Table("AddNewUsers")]
    public class AddNewUser
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Title { get; set; }
        public string Area { get; set; }
        public int ReportTo { get; set; }
        public int Status { get; set; }
    }
}