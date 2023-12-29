using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssignmentDay17_WebApi.Models
{
    [Table("Teams")]
    public class Teams
    {
        [Key]
        public int TId { get; set; }
        [Required]
        [StringLength(50)]
        public string TName { get; set; }
        [Required]
        [StringLength(50)]
        public string TEmail { get; set; }
        [Required]
        [StringLength(50)]
        public string SLogan { get; set; }
    }
}