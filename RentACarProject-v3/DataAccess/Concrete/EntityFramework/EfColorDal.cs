using Core.DataAccess.EntityFramework;   // EfEntityRepositoryBase'i implemente edebilmek için
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // DataAccess içerisine NuGet'ten  EntityFramework indirdik.

    //  IColorDal'dan miras almasının sebebi o sınıfa ait özel bir işlem olursa (join gibi) onu implemente edebbilmek için.
    //  Sonuçta onu her tabloda uygulamayacağımız için ona özel olur ve DataAccess > Abstract > IColorDal'da tanımlanır.
    public class EfColorDal : EfEntityRepositoryBase<Color, RentACarContext>, IColorDal   // IColorDal'in istediği imzalar EfEntityRepositoryBase içerisinde mevcut. O yüzden EfEntityRepositoryBase'i implemente ediyoruz.
    {

    }
}
