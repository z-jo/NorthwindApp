using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthwindApp_DAL;

namespace NorthwindApp.Models
{
    public class EmployeeModel
    {
        public string LastName { set; get; }
        public string FirstName { set; get; }
        public string Title { set; get; }
        public string Address { set; get; }
        public string City { set; get; }
        public string Region { set; get; }
        public string PostalCode { set; get; }
        public string Country { set; get; }


    }
}