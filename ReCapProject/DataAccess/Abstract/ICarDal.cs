﻿using Entities.Concrete;  // Önce referans olarak Entites katmanını projeye ekledik.
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAllByBrand(int brandId);
    }
}
