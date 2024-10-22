using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoSoDuAn.Model
{
    public partial class User_Department
    {
        public string UserID { get; set; }
        public string DepartmentID { get; set; }
        public string Role { get; set; }
        public DateTime AssignedDate { get; set; }

        public virtual User UserIDNavigation { get; set; }
        public virtual Department DepartmentIDNavigation { get; set; }

    }
}
