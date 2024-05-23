using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string FirstTitle { get; set; }
        public string FirstDescription { get; set; }
        public string FirstImg { get; set; }
        public string SecondTitle { get; set; }
        public string SecondDescription { get; set; }
        public bool Status { get; set; }
    }
}
