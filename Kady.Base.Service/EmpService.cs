using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kady.Base.Entity;
using Kady.Base.Interface.Repository;
using Kady.Base.Interface.Service;

namespace Kady.Base.Service
{
    public class EmpService:IEmpService
    {
        private readonly IEmpRepository _empRepository;

        public EmpService(IEmpRepository empRepository)
        {
            _empRepository = empRepository;
        }
        public int Upsert(Entity.Employee employee)
        {
            if (employee.Id == Guid.Empty)
            {
               return _empRepository.Add(employee);
            }
            return _empRepository.Update(employee);
        }

        public PagedList.IPagedList<Entity.Employee> GetAll(int page, int pagesize)
        {
            return _empRepository.GetAll(page, pagesize);
        }


        public Employee GetbyId(Guid id)
        {
            return _empRepository.GetbyId(id);
        }
    }
}
