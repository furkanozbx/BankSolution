using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Repository.Abstract
{
    public interface IDatabaseBusiness<T> where T : class
    {
        void Insert(T data);
        void Update(T data);
        void Delete(T data);
        void Delete(int id);
        List<T> GetAll();
        T Get(int id);
        T Get(Expression<Func<T, bool>> predicate);
    }
}
