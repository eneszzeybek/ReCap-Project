using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal // Dal -> Data Access Layer
    {
        List<Car> GetAll(); // Add Project Reference to Entities
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetById(int Id);

    }
}
