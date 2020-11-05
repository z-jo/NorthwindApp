using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Cors;
using NorthwindApp.Models;
using NorthwindApp_DAL;

namespace NorthwindApp.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult GetEmployeeList()
        {
            NorthwindEntities db = new NorthwindEntities();
            {
                var custList = (from e in db.Employees
                                where (e.IsDeleted ?? false) == false
                                select new Models.EmployeeModel
                                {
                                    EmployeeID = e.EmployeeID,
                                    LastName = e.LastName,
                                    FirstName = e.FirstName,
                                    Title = e.Title,
                                    Address = e.Address,
                                    City = e.City,
                                    Region = e.Region,
                                    PostalCode = e.PostalCode,
                                    Country = e.Country
                                }).ToList();

                return Json(new { data = custList }, JsonRequestBehavior.AllowGet);
            }
        }


        public ActionResult DeleteEmployee(EmployeeModel employee)
        {
            var delEmp = EmployeeModel.DeleteEmployee(employee.EmployeeID);

            return Json(new { success = delEmp });
        }

        
        public ActionResult EditEmployee(EmployeeModel employee)
        {
            var editEmp = EmployeeModel.EditEmployee(employee);

            return Json(new { success = editEmp });
        }

        public ActionResult About()
        {
            
            return View();
        }

        public ActionResult DataTable()
        {
            
            return View();
        }

    }
}