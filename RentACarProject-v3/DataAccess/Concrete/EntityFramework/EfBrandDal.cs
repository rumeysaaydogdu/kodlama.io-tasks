using Core.DataAccess.EntityFramework;   // EfEntityRepositoryBase'i implemente edebilmek için
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;   // EntityState'i kullanabilmek için
using System;
using System.Collections.Generic;
using System.Linq;  // SingleOrDefault için
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //  IBrandDal'dan miras almasının sebebi o sınıfa ait özel bir işlem olursa (join gibi) onu implemente edebbilmek için.
    //  Sonuçta onu her tabloda uygulamayacağımız için ona özel olur ve DataAccess > Abstract > IBrandDal'da tanımlanır.
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal   // IBrandDal'in istediği imzalar EfEntityRepositoryBase içerisinde mevcut. O yüzden EfEntityRepositoryBase'i implemente ediyoruz.
    {

    }
}
