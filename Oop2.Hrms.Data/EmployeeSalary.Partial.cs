using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2.Hrms.Data
{
    public partial class EmployeeSalary
    {
        public int isTotal
        {
            get { return this.Basic + this.HouseAlignment + this.MedicalFacilities; }
        }


    }
}
