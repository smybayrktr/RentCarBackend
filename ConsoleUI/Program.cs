using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //InMemoryTest();
            //EfCarDalTest();
            EfCarDalTest2();

        }

        private static void EfCarDalTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();
            car.Name = "Yeşil Araba";
            car.BrandId = 5;
            car.ColorId = 2;
            car.DailyPrice = 0;
            car.Description = "2010 model yeni bakımdan çıkmış araba";
            car.Id = 6;
            car.ModelYear = 2010;
            carManager.Verification(car);
        }

        private static void EfCarDalTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Name);
            }
        }

        private static void InMemoryTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}
