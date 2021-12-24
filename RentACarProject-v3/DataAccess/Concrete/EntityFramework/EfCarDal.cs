using Core.DataAccess.EntityFramework;   // EfEntityRepositoryBase'i implemente edebilmek için
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;   // EntityState'i kullanabilmek için
using System;
using System.Collections.Generic;
using System.Linq;  // SingleOrDefault için
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //  ICarDal'dan miras almasının sebebi o sınıfa ait özel bir işlem olursa (join gibi) onu implemente edebbilmek için.
    //  Sonuçta onu her tabloda uygulamayacağımız için ona özel olur ve DataAccess > Abstract > ICarDal'da tanımlanır.
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal  // ICarDal'in istediği imzalar EfEntityRepositoryBase içerisinde mevcut. O yüzden EfEntityRepositoryBase'i implemente ediyoruz.
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 CarName = c.Name,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice
                             };

                return result.ToList();
            }
        }
    }
}
