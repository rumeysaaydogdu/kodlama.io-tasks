using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;  // global olduğu için altı çizili olur

        public InMemoryCarDal()  // ctor yazıp tab tab ile oluşturabiliriz. Constructor : bellekte referans aldığı zaman çalışacak blok
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 1_250_000, Description = "Range Rover", ModelYear = "2019"},  // {} içindeyken ctrl space ile alanlar gelir
                new Car{Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 350_000, Description = "Renault Clio", ModelYear = "2017"},
                new Car{Id = 3, BrandId = 3, ColorId = 1, DailyPrice = 150_000, Description = "Citroen C3", ModelYear = "2016"} 
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)   // Linq kullandık
        {
            // _cars.Remove(car);  // bu şekilde silemeyiz. Referans tipli olduğu için ID göndersen bile int değer tipli. string olsa siler. Id ile referansı yakalamamız gerekir.

            Car carToDelte = _cars.SingleOrDefault(c => c.Id == car.Id);  // id aramalarında SingleOrDefault

            _cars.Remove(carToDelte);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();  //  _cars.Where(c => c.BrandId == brandId).ToList() LİSTE TÜRÜNDE. içindeki şarta uyanları yeni bir liste yapar WHERE
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = carToUpdate.ModelYear;
        }
    }
}
