using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDExcellent.Models
{
    [Table("RequestSurveys")]
    public class RequestSurvey
    {
        [Key]
        public int SurveyId { get; set; }
        [Required]
        public string SurveyName { get; set; }
        public string SurveyQuestion { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Get_by { get; set; }
        public string Email { get; set; }
    }
}