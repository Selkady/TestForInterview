using System;
using System.Data.Entity;
using System.Linq;
using Kady.Base.DAL;
using Kady.Base.Entity;
using Kady.Base.Interface.Repository;
using PagedList;

namespace Kady.Base.Repository
{
    public class EmpRepository : IEmpRepository
    {
        private TestEntities _testEntities;

        public EmpRepository(TestEntities testEntities)
        {
            _testEntities = testEntities;
        }

        public int Add(Employee employee)
        {
            _testEntities.Employees.Add(employee);

            return _testEntities.SaveChanges();
        }

        public int Update(Employee employee)
        {

            _testEntities.Entry(employee).State = EntityState.Modified;


            return _testEntities.SaveChanges();
        }

        public IPagedList<Employee> GetAll(int page, int pagesize)
        {
            return _testEntities.Employees.OrderBy(c=>c.Name).ToPagedList(page, pagesize);
        }

        public Employee GetbyId(Guid id)
        {
            return _testEntities.Employees.SingleOrDefault(c => c.Id == id);
        }
    }
}
