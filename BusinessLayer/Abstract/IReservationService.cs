using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        //Artık bu metoda ihtiyacımız kalmadı alttaki metot daha kapsamlı ve mimari açıdan daha doğrudur
        //List<Reservation> TGetApprovalReservation(int id); //sadece burada kullanmak istediğimden ötürü buranın servis kısmına yazdım.
        List<Reservation> TGetListWithReservationByWaitApproval(int id); 
        List<Reservation> TGetListWithReservationByAccepted(int id); 
        List<Reservation> TGetListWithReservationByPrevious(int id); 

    }
}
