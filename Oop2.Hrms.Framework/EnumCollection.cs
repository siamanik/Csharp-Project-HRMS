using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2.Hrms.Framework
{
    public static class EnumCollection
    {
        public enum UserTypeEnum
        {
            Admin=1,
            Employee=0
        }

        public enum UserStatusEnum
        {
            Pending=1,
            Approved=2,
            Rejected=3
        }


        public enum EmpSalaryStatusEnum
        {
            Current = 1,
            Previous = 0,
         
        }




        public static List<EnumDetail> UserStatusList()
        {
            var list = new List<EnumDetail>();

            list.Add(new EnumDetail() { ID = 1, Name = "Pending" });
            list.Add(new EnumDetail() { ID = 2, Name = "Approved" });
            list.Add(new EnumDetail(){ID=3,Name="Rejected"});

            return list;
        }

        public static List<EnumDetail> UserTypeList()
        {
            var list = new List<EnumDetail>();

            list.Add(new EnumDetail(){ID = 1, Name = "Admin"});
            list.Add(new EnumDetail() { ID = 0, Name = "Employee" });

            return list;
        }

        public static List<EnumDetail> EmpSalaryStatusList()
        {
            var list = new List<EnumDetail>();

            list.Add(new EnumDetail() { ID = 1, Name = "True" });
            list.Add(new EnumDetail() { ID = 0, Name = "False" });

            return list;
        }


    }

    public class EnumDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
