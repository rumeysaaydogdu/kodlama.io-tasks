using Core.DataAccess;   // IEntityRepository'den miras alabilmek için
using Entities.Concrete;  // <Car> için
using Entities.DTOs;    // CarDetailDto için
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>    //   IEntityRepository den alıyor işlemleri
    {
        List<CarDetailDto> GetCarDetails();

        // IEntityRepository yazınca gerek kalmıyor.
        //List<Car> GetAll();
        //void Add(Car car);
        //void Delete(Car car);
        //void Update(Car car);
        //List<Car> GetAllByBrand(int brandId);
    }
}
