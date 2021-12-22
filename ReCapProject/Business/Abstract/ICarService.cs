using Entities.Concrete;  // Önce referans olarak Entites ve DataAccess katmanını projeye ekledik.
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
    }
}
