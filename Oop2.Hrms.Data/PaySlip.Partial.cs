using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Oop2.Hrms.Data
{
    public partial class PaySlip
    {
        public int isTotal
        {
            get { return this.Basic + this.HouseAlignment + this.MedicalFacilities; }
        }

        public int isRemain
        {
            get { return this.isTotal + this.Addition - this.Deduction; }
        }
    }
}
