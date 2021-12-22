using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;  // soyut nesneyle bağlantı kuruyoruz. Injection.

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            // İş kodları
            // Yetkisi var mı?  

            return _carDal.GetAll();

        }
    }
}
