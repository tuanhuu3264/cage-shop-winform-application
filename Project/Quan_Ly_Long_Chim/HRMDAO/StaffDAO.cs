using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDAO
{
    public class StaffDAO
    {
        private static StaffDAO instance = null;
        private StaffDAO() { }

        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StaffDAO();
                }
                return instance;
            }
        }
        public List<staff> listStaffs()
        {
            using var db = new CAGE_SHOPContext();
            return db.staff.Include(c => c.Orders).Include(c => c.Reports).ToList();
        }
        public staff GetStaff(string id)
        {
            var temp = listStaffs().SingleOrDefault(m => m.Id.Equals(id));
            return temp;
        }
        public void insertStaff(staff s)
        {
            using var db = new CAGE_SHOPContext();
            db.staff.Add(s);
            db.SaveChanges();
        }
        public void updateStaff(staff s)
        {
            using var db = new CAGE_SHOPContext();
            db.staff.Update(s);
            db.SaveChanges();
        }
        public void deleteStaff(string id)
        {
            staff s = GetStaff(id);
            if(s != null)
            {
                using var db = new CAGE_SHOPContext();
                db.staff.Remove(s);
                db.SaveChanges();
            }
        }
        public staff CheckLogin(string email, string password)
        {
            using var db = new CAGE_SHOPContext();
            var staff = db.staff.AsEnumerable().SingleOrDefault(m => m.Email.ToLower().Trim().Equals(email.Trim().ToLower())&&m.Password.Equals(password)) ;
            return staff;
        }
    }
}
