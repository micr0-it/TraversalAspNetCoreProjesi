using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AboutOther
    {
        [Key]
        public int AboutOtherID { get; set; }
        public string FirstTitle { get; set; }
        public string SecondTitle { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
    }
}
