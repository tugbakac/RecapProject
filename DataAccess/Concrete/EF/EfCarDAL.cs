using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EF
{
    public class EfCarDAL : IEntityRepository<Car>
    {
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
