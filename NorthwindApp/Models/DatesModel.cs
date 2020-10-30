using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthwindApp_DAL;

namespace NorthwindApp.Models
{
    public class DatesModel
    {
        public int EmployeeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}