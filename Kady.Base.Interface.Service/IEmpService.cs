using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kady.Base.Entity;
using PagedList;

namespace Kady.Base.Interface.Service
{
    public interface IEmpService
    {
        int Upsert(Employee employee);
        IPagedList<Employee> GetAll(int page, int pagesize);
        Employee GetbyId(Guid id);

    }
}
