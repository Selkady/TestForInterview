using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kady.Base.Entity;
using Kady.Base.Interface.Service;
using TestForLink.Helper;

namespace TestForLink.Controllers
{
    public class EmpController : Controller
    {
        private readonly IEmpService _empService;

        public EmpController(IEmpService empService)
        {
            _empService = empService;
        }
        //
        // GET: /Emp/
        public ActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var empolyees = _empService.GetAll(pageNumber, CustomConfig.PageSize);
            if (Request.IsAjaxRequest())
            {
                return PartialView("_employeeIndex", empolyees);
            }
            return View(empolyees);
        }

        public ActionResult Edit(Guid id)
        {
            var employee = _empService.GetbyId(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var employeesave = _empService.Upsert(employee);
                if (employeesave < 0)
                {
                    return HttpNotFound();
                }
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}