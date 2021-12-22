using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    // SOLID
    // open Closed principle
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            //CarManager carManager = new CarManager(new InMemoryCarDal());

            //foreach(var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
        }
    }
}
