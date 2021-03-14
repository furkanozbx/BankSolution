using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Bank.Service
{
    [ServiceContract]
    public interface IBankService
    {
        [OperationContract]
        User Login(string username,string password);
    }

}
