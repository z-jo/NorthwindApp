﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Cors;
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
                                select new Models.EmployeeModel
                                {
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


        public ActionResult About()
        {
            
            return View();
        }

        public ActionResult DataTable()
        {
            
            return View();
        }

        public ActionResult DataTableAxios()
        {

            return View();
        }
    }
}