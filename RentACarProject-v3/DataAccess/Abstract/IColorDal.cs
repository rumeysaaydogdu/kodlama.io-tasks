using Core.DataAccess;   // IEntityRepository'den miras alabilmek için
using Entities.Concrete;  // <Color> için
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>    //   IEntityRepository den alıyor işlemleri
    {
    }
}
