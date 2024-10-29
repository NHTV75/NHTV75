using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositories;
using System.Threading.Tasks;
using Repositories.Model;

namespace Services
{
    public class DepartmentService
    {
        DeparmentRepository deparmentRepository = new DeparmentRepository();

        public List<Department> getListDepartment()
        {
            return deparmentRepository.getDataDepartment();
        }

        public void create(string departmentName, string managerID, string description)
        {
            deparmentRepository.createDepartment(departmentName, managerID, description);
        }

        public void update(string departmentID, string managerID, string description)
        {
            deparmentRepository.updateDepartment(departmentID, managerID, description);
        }
    }
}
