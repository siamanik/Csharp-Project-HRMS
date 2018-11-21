using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2.Hrms.Data
{
    public partial class EmployeeInfo
    {
        public string FullName
        {
            get
            {
                if (this.UserInfo != null)
                    return this.UserInfo.FullName;

                return "";
            }
        }

        public string Email
        {
            get
            {
                if (this.UserInfo != null)
                    return this.UserInfo.Email;

                return "";
            }
        }
    }
}



