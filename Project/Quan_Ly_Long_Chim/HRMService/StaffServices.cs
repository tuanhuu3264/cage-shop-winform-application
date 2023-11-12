using BusinessObject.Models;
using HRMRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMService
{
    public class StaffServices : IStaffServices
    {
        private IStaffRepositories staffRepositories;
        public StaffServices()
        {
            staffRepositories = new StaffRepositories();
        }
        public void deleteStaff(string id)
        {
            staffRepositories.deleteStaff(id);
        }
        public staff GetStaff(string id)
        {
            return staffRepositories.GetStaff(id);
        }

        public void insertStaff(staff s)
        {
            staffRepositories.insertStaff(s);
        }

        public List<staff> listStaffs()
        {
            return staffRepositories.listStaffs();
        }

        public void updateStaff(staff s)
        {
            staffRepositories.updateStaff(s);
        }
        public staff checkLogin(string email, string password)
        {
            return staffRepositories.checkLogin(email, password);   
        }
    }
}
