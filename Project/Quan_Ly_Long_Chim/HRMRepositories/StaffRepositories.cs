using BusinessObject.Models;
using HRMDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMRepositories
{
    public class StaffRepositories : IStaffRepositories
    {
        public void deleteStaff(string id)
        => StaffDAO.Instance.deleteStaff(id);

        public staff GetStaff(string id)
        => StaffDAO.Instance.GetStaff(id);

        public void insertStaff(staff s)
        => StaffDAO.Instance.insertStaff(s);
        public List<staff> listStaffs()
        => StaffDAO.Instance.listStaffs();

        public void updateStaff(staff s)
        => StaffDAO.Instance.updateStaff(s);
        public staff checkLogin(string email, string password) => StaffDAO.Instance.CheckLogin(email,password);
    }
}
