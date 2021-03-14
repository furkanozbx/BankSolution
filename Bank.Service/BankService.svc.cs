using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Bank.Domain.Repository.Concrete;
using Bank.Entities;

namespace Bank.Service
{
    public class BankService : IBankService
    {
        UserBusiness userBusiness = new UserBusiness();
        public User Login(string username, string password)
        {
            return userBusiness.Get(u => u.Username == username && u.Password == password);
        }
    }
}
