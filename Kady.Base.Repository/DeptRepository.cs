using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Kady.Base.DAL;
using Kady.Base.Interface.Repository;
using PagedList;

namespace Kady.Base.Repository
{
    public class DeptRepository : IDeptRepository
    {
        private TestEntities _testEntities;

        public DeptRepository(TestEntities testEntities)
        {
            _testEntities = testEntities;
        }
        public int Add(Entity.Dept dept)
        {
            _testEntities.Depts.Add(dept);

            return _testEntities.SaveChanges();
        }

        public int Update(Entity.Dept dept)
        {
            _testEntities.Entry(dept).State = EntityState.Modified;

            return _testEntities.SaveChanges();
        }



        public IPagedList<Entity.Dept> GetAll(int page, int pagesize)
        {
            return _testEntities.Depts.ToPagedList(page, pagesize);

        }

        public List<Entity.Dept> GetAll()
        {
            return _testEntities.Depts.ToList();
        }
    }
}
