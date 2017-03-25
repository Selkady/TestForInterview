using System;
using System.Collections.Generic;
using Kady.Base.Interface.Repository;
using Kady.Base.Interface.Service;

namespace Kady.Base.Service
{
    public class DeptService:IDeptService
    {
        private readonly IDeptRepository _deptRepository;

        public DeptService(IDeptRepository deptRepository)
        {
            _deptRepository = deptRepository;
        }
        public int Upsert(Entity.Dept dept)
        {
            if (dept.Id == Guid.Empty)
            {
                dept.Id = Guid.NewGuid();
                return _deptRepository.Add(dept);
            }
            return _deptRepository.Update(dept);
        }

        public PagedList.IPagedList<Entity.Dept> GetAll(int page, int pagesize)
        {
            return _deptRepository.GetAll(page, pagesize);
        }

        public List<Entity.Dept> GetAll()
        {
            return _deptRepository.GetAll();
        }
    }
}
