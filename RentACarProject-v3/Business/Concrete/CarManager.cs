using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)  // KURALIMIZ: Araba ismi minimum 2 karakter olmalıdır ve araba günlük fiyatı 0'dan büyük olmalıdır.
            {
                _carDal.Add(car);
                Console.WriteLine("Araba Eklendi");
            }
            else
            {
                Console.WriteLine("Araba Kaydı Başarısız");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            // İş kodları
            // Yetkisi var mı?  

            return _carDal.GetAll();

        }

        public Car GetById(int id)  // Select * from Car where Id = 1
        {
            return _carDal.Get(c => c.Id == id);     // aracn id sine göre getirme
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);  //her c için c'nin BrandId'si benim gönderdiğim id ye yani BrandId'ye eşitse onları döndür
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);  //her c için c'nin ColorId'si benim gönderdiğim id ye yani ColorId'ye eşitse onları döndür
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
