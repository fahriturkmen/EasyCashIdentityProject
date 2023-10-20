using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal=customerAccountProcessDal;
        }

        public void Service_Delete(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.Delete(t);
        }

        public CustomerAccountProcess Service_GetByID(int id)
        {
            return _customerAccountProcessDal.GetByID(id);
        }

        public List<CustomerAccountProcess> Service_GetList()
        {
            return _customerAccountProcessDal.GetList();
        }

        public void Service_Insert(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.Insert(t);
        }

        public List<CustomerAccountProcess> Service_MyLastProcess(int id)
        {
            return _customerAccountProcessDal.MyLastProcess(id);
        }

        public void Service_Update(CustomerAccountProcess t)
        {
           _customerAccountProcessDal.Update(t);
        }
    }
}
