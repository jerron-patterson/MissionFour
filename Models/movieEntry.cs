using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MissionFour.Models
{
    public class movieEntry
    {
        [Key]
        [Required]
        public int movieID { get; set; }
        [Required]
        public int categoryID { get; set; }
        public mCat category { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public short year { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lentTo { get; set; }
        public string notes { get; set; }
    }
}
