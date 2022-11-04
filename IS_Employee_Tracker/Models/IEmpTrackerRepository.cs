using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IS_Employee_Tracker.Models;

namespace IS_Employee_Tracker.Models
{
    public interface IEmpTrackerRepository
    {
        IQueryable<EmployeeInfo> Information { get; }
        public void SaveChanges(EmployeeInfo e);
        public void Add(EmployeeInfo e);
        public void Update(EmployeeInfo e);
        public void Delete(EmployeeInfo e);
    }
}
