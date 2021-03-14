using Bank.Domain.Repository.Abstract;
using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Repository.Concrete
{
    public class UserBusiness : IDatabaseBusiness<User>
    {
        public void Delete(User data)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            using (BankDbEntities db = new BankDbEntities())
            {
                return db.Users.Find(id);
            }
        }

        public User Get(Expression<Func<User, bool>> predicate)
        {
            using (BankDbEntities db = new BankDbEntities())
            {
                return db.Users.Where(predicate).FirstOrDefault();
            }
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(User data)
        {
            throw new NotImplementedException();
        }

        public void Update(User data)
        {
            throw new NotImplementedException();
        }
    }
}
