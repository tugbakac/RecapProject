using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDAL : ICarDAL
    {
        List<Car> _cars;
        public InMemoryDAL()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    CarId=1,
                    ModelYear=DateTime.Now,
                    BrandId=2,
                    DailyPrice=150,
                    ColorId=1,
                    CarDescription="Car"
                },
                new Car
                {
                    CarId=2,
                    ModelYear=DateTime.Now,
                    BrandId=3,
                    DailyPrice=150,
                    ColorId=2,
                    CarDescription="Car2"
                }
            };
        }

        public void Add(Car Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car Entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car Entity)
        {
            throw new NotImplementedException();
        }
    }
}
