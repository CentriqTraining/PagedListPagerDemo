using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication8.Models
{

    public class Employee
    {
        private int _ID;
        private string _FirstName;
        private string _LastName;
        private string _Position;
        private decimal _Salary;
        private DateTime? _TerminationDate;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }

        public decimal Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }

        public DateTime? TerminationDate
        {
            get { return _TerminationDate; }
            set { _TerminationDate = value; }
        }
    }
}