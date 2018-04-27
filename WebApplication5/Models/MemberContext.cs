using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class MemberContext
    {
        AngularEfContext db = new AngularEfContext();

        public IEnumerable<Member> GetAllEmployees()
        {
            try
            {
                return db.Member.ToList();

            }
            catch
            {
                throw;
            }
        }
        //To Add new employee record   
        public int AddEmployee(Member employee)
        {
            try
            {
                db.Member.Add(employee);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar member 
        public int UpdateEmployee(Member employee)
        {
            try
            {
                db.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular employee  
        public Member GetEmployeeData(int id)
        {
            try
            {
                Member employee = db.Member.Find(id);
                return employee;
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular employee  
        public int DeleteEmployee(int id)
        {
            try
            {
                Member emp = db.Member.Find(id);
                db.Member.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To Get the list of Cities  
        //public List<TblCities> GetCities()
        //{
        //    List<TblCities> lstCity = new List<TblCities>();
        //    lstCity = (from CityList in db.TblCities select CityList).ToList();
        //    return lstCity;
        //}
    }
}

