using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car {Id=1, BrandId=1, ColorId=1, DailyPrice=1000, Description="Bakımı yeni yapılmıştır", ModelYear=2015, Name="Mavi Spor Araba"},
            new Car {Id=2, BrandId=2, ColorId=1, DailyPrice=500, Description="Bakımı yeni yapılmıştır", ModelYear=2014, Name="Mavi Clasic Araba"},
            new Car {Id=3, BrandId=2, ColorId=2, DailyPrice=750, Description="Bakımı yeni yapılmıştır", ModelYear=2009, Name="Siyah Spor Araba"},
            new Car {Id=4, BrandId=3, ColorId=3, DailyPrice=900, Description="Bakımı yeni yapılmıştır", ModelYear=2000, Name="Gri Doblo"},
            new Car {Id=5, BrandId=4, ColorId=4, DailyPrice=1450, Description="Bakımı yeni yapılmıştır", ModelYear=2019, Name="Kırmızı Araba"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var delete = _cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(delete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            var update = _cars.SingleOrDefault(p => p.Id == car.Id);
            update.BrandId = car.BrandId;
            update.ColorId = car.ColorId;
            update.DailyPrice = car.DailyPrice;
            update.Description = car.Description;
            update.ModelYear = car.ModelYear;
            update.Name = car.Name;
        }
    }
}
