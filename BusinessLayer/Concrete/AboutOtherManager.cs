using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutOtherManager : IAboutOtherService
    {
        IAboutOtherDal _aboutOtherDal;

        public AboutOtherManager(IAboutOtherDal aboutOtherDal)
        {
            _aboutOtherDal = aboutOtherDal;
        }

        public void TAdd(AboutOther t)
        {
            _aboutOtherDal.Insert(t);
        }

        public void TDelete(AboutOther t)
        {
            _aboutOtherDal.Delete(t);
        }

        public AboutOther TGetByID(int id)
        {
            return _aboutOtherDal.GetById(id);
        }

        public List<AboutOther> TGetList()
        {
            return _aboutOtherDal.GetList();
        }

        public void TUpdate(AboutOther t)
        {
            _aboutOtherDal.Update(t);
        }
    }
}
