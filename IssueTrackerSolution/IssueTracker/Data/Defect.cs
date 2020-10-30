using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Data
{
    public class Defect
    {
        public int Id { get; set; }
        [DisplayName("Describe the Defect")]
        [Required][MaxLength(200)]
        public string Description { get; set; }
        [DisplayName("Opened By (your name)")]
        [Required]
        public string OpenedBy { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Closed { get; set; }
    }
}
