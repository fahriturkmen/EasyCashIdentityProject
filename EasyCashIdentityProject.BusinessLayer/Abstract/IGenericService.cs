using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Service_Insert(T t);
        void Service_Delete(T t);
        void Service_Update(T t);
        T Service_GetByID(int id);
        List<T> Service_GetList();
    }
}
