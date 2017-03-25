using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kady.Base.Entity;
using PagedList;

namespace Kady.Base.Interface.Repository
{
    public interface IDeptRepository
    {
        int Add(Entity.Dept dept);
        int Update(Entity.Dept dept);
        IPagedList<Dept> GetAll(int page, int pagesize);
        List<Dept> GetAll();
    }
}
