using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest_TESS.Models
{
    public class Tasks
    {
        [Key]
        public int pk_Task { get; set; }
        [Required]
        public string name_Task { get; set; }
        [Required]
        public DateTime date_Task { get; set; }
        public Boolean complete_Task { get; set; }
    }
}
