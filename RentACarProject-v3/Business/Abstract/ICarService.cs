using Entities.Concrete;  // Önce referans olarak Entites ve DataAccess katmanını projeye ekledik.
using Entities.DTOs;  // CarDetailDto yı çözümledik
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);    // aracn id sine göre getirme. expression bulunan Get() metoduyla çalışacak
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<CarDetailDto> GetCarDetails();

        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
