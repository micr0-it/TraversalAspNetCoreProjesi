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
    public class FeatureOtherManager : IFeatureOtherService
    {
        IFeatureOtherDal _featureOtherDal;

        public FeatureOtherManager(IFeatureOtherDal featureOtherDal)
        {
            _featureOtherDal = featureOtherDal;
        }

        public void TAdd(FeatureOther t)
        {
            _featureOtherDal.Insert(t);
        }

        public void TDelete(FeatureOther t)
        {
            _featureOtherDal.Delete(t);
        }

        public FeatureOther TGetByID(int id)
        {
            return _featureOtherDal.GetById(id);
        }

        public List<FeatureOther> TGetList()
        {
            return _featureOtherDal.GetList();
        }

        public void TUpdate(FeatureOther t)
        {
            _featureOtherDal.Update(t);
        }
    }
}
