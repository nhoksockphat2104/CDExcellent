using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDExcellent.Models
{
    [Table("AddArticles")]
    public class AddArticle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Creator { get; set; }
        public DateTime DateCreate { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
    }
}