using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;  // Add yaparken sınıf için
using System;

namespace ConsoleUI
{
    // SOLID
    // open Closed principle
    class Program
    {
        static void Main(string[] args)
        {
            //GetCarDto();

            //CarGetAll();
            //CarGetById();
            //CarAdd();
            //CarUpdate();
            //CarDelete();

            //BrandGetAll();
            //BrandGetById();
            //BrandAdd();

            //InMemory();

        }

        private static void GetCarDto()
        {

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);  // Dto ile join işlemi sayesinde 3 tabloyu birleştirdik.
            }
        }
        private static void CarGetAll()
        {

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);  // tablodaki araçların açıklamasını ekrana getirdik.
                Console.WriteLine(car.Name);  // tablodaki araçların adını ekrana getirdik.
            }
        }
        private static void CarGetById()
        {

            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine(carManager.GetById(1).DailyPrice);  // aracın id'sine göre fiyatını ekrana getirdik.
        }
        private static void CarAdd()
        {

            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { BrandId = 2, ColorId = 3, DailyPrice = 550, ModelYear = "2020", Name = "Mercedes", Description = "Mercedes araç" });   // yeni bir araç ekledik.

        }
        private static void CarUpdate()
        {

            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Update(new Car { Id = 2, BrandId = 2, ColorId = 3, DailyPrice = 525, ModelYear = "2020", Name = "Mercedes", Description = "Mercedes araç" });   // var olan aracı güncelledik.

        }
        private static void CarDelete()
        {

            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Delete(new Car { Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 550, ModelYear = "2020", Name = "Mercedes", Description = "Mercedes araç" });   // var olan aracı sildik.

        }
        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);  // tablodaki markaların adını ekrana getirdik.
            }

        }
        private static void BrandGetById()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine(brandManager.GetById(1).Name);  // markanın id'sine göre adını ekrana getirdik.


        }
        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand { Name = "Mercedes" });   // yeni bir marka ekledik.


        }
        private static void InMemory()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
