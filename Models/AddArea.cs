using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CDExcellent.Models
{
    [Table("AddAreas")]
    public class AddArea
    {
        [Key]
        public int AreaId { get; set; }
        [Required]
        public int AreaCode { get; set; }
        public string AreaName { get; set; }
        public int DistributorQty { get; set; }
    }
}