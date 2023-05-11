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
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal=customerAccountDal;
        }

        public void Service_Delete(CustomerAccount t)
        {
            _customerAccountDal.Delete(t);
        }

        public CustomerAccount Service_GetByID(int id)
        {
            return _customerAccountDal.GetByID(id);
        }

        public List<CustomerAccount> Service_GetList()
        {
            return _customerAccountDal.GetList();
        }

        public void Service_Insert(CustomerAccount t)
        {
           _customerAccountDal.Insert(t);
        }

        public void Service_Update(CustomerAccount t)
        {
            _customerAccountDal.Update(t);
        }
    }
}
