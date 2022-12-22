using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDExcellent.Models
{
    [Table("CreatePlanVisits")]
    public class CreatePlanVisit
    {
        [Key]
        public int PlanId { get; set; }
        [Required]
        public DateTime Time { get; set; }
        public int Distributor { get; set; }
        public string Purpose { get; set; }
        public string Guest { get; set; }
    }
}