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
        public InMemoryCarDal() // Ctor
        {
            // SQL Server
            _cars = new List<Car> {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2018, DailyPrice = 500, Description = "BMW"},
                new Car{Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2017, DailyPrice = 400, Description = "Mercedes"},
                new Car{Id = 3, BrandId = 3, ColorId = 2, ModelYear = 2016, DailyPrice = 300, Description = "Audi"},
                new Car{Id = 4, BrandId = 1, ColorId = 1, ModelYear = 2019, DailyPrice = 600, Description = "BMW"},
                new Car{Id = 5, BrandId = 2, ColorId = 3, ModelYear = 2015, DailyPrice = 200, Description = "Mercedes"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id); // => "Lambda"
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

    }
}
