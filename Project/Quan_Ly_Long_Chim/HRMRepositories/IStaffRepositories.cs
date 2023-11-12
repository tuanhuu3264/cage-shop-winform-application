using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMRepositories
{
    public interface IStaffRepositories
    {
         List<staff> listStaffs();

         staff GetStaff(string id);
         void insertStaff(staff s);

         void updateStaff(staff s);

         void deleteStaff(string id);
        staff checkLogin(string email, string password);
     
    }
}
