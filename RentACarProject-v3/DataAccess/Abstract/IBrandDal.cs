using Core.DataAccess;   // IEntityRepository'den miras alabilmek için
using Entities.Concrete;   // <Brand> için
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepository<Brand>    //   IEntityRepository den alıyor işlemleri
    {

    }
}
