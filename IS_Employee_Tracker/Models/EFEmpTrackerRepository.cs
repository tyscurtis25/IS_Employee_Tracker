using IS_Employee_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS_Employee_Tracker.Models
{
    public class EFEmpTrackerRepository : IEmpTrackerRepository
    {
        private EmployeeTrackerContext _context { get; set; }
        public EFEmpTrackerRepository (EmployeeTrackerContext temp)
        {
            _context = temp;
        }

        public IQueryable<EmployeeInfo> Information => _context.Information;

        public void SaveChanges(EmployeeInfo e)
        {
            _context.SaveChanges();
        }

        public void Add(EmployeeInfo e)
        {
            _context.Add(e);
            _context.SaveChanges();
        }

        public void Update(EmployeeInfo e)
        {
            _context.Update(e);
            _context.SaveChanges();
        }

        public void Delete(EmployeeInfo e)
        {
            _context.Remove(e);
            _context.SaveChanges();
        }

        //public void SaveBook(Bowler b)
        //{
        //    _context.SaveChanges();
        //}

        //public void CreateBook(Bowler b)
        //{
        //    _context.Add(b);
        //    _context.SaveChanges();
        //}

        //public void DeleteBook(Bowler b)
        //{
        //    _context.Remove(b);
        //    _context.SaveChanges();
        //}
    }
}
