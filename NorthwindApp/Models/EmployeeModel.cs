using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwindApp_DAL;

namespace NorthwindApp.Models
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string LastName { set; get; }
        public string FirstName { set; get; }
        public string Title { set; get; }
        public string Address { set; get; }
        public string City { set; get; }
        public string Region { set; get; }
        public string PostalCode { set; get; }
        public string Country { set; get; }

        public static bool DeleteEmployee(int employeeId)
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                {
                    var emp = db.Employees.Where(x => x.EmployeeID == employeeId && x.IsDeleted == false).FirstOrDefault();

                    if (emp != null)
                    {
                        emp.IsDeleted = true;
                        db.SaveChanges();
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool EditEmployee(EmployeeModel e)
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                {
                    var emp = db.Employees.Where(x => x.EmployeeID == e.EmployeeID && x.IsDeleted == false).FirstOrDefault();

                    if (emp != null)
                    {
                        emp.FirstName = e.FirstName;
                        emp.LastName = e.LastName;
                        emp.Title = e.Title;                        
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }


}