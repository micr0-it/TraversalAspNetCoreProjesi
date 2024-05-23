using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DuringTime { get; set; } // Kaç gün, kaç gece
        public string Price { get; set; }
        public string Img { get; set; }
        public string ThumbnailImg { get; set; }
        public string Description { get; set; }
        public string FirstDetail { get; set; }
        public string SecondDetail { get; set; }
        public string ThirdDetail { get; set; }
        public string DetailImg { get; set; }
        public string Quotation { get; set; }
        public bool Status { get; set; } // tur aktif mi pasif mi
        public int Capacity { get; set; } // tur kişi sayısı
        public List<Comment> Comments { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
