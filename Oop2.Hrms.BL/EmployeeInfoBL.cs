using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oop2.Hrms.Data;

namespace Oop2.Hrms.BL
{
    public class EmployeeInfoBL
    {
        private HRDBEntities _context = new HRDBEntities();

        public List<EmployeeInfo> GetAll(string key = "")
        {
            IEnumerable<EmployeeInfo> query = _context.EmployeeInfoes;

            if (!string.IsNullOrEmpty(key))
            {
                int id;
                if(Int32.TryParse(key, out id))
                {
                    query = query.Where(q => q.ID == id);
                }
                else
                {
                    query =
                        query.Where(
                            q =>
                                q.UserInfo.FirstName.Contains(key) || q.UserInfo.LastName.Contains(key) ||
                                q.UserInfo.Email.Contains(key));
                }
            }
            return query.ToList();
        }

        public EmployeeInfo Save(EmployeeInfo value, out string error)
        {
            error = string.Empty;

            using (var scope=_context.Database.BeginTransaction())
            {
                try
                {
                    var employee = _context.EmployeeInfoes.FirstOrDefault(u => u.ID == value.ID);
                    var user = _context.UserInfoes.FirstOrDefault(u => u.ID == value.ID);

                    if (user==null)
                    {
                        user = new UserInfo();
                        _context.UserInfoes.Add(user);
                    }

                    user.FirstName = value.UserInfo.FirstName;
                    user.LastName = value.UserInfo.LastName;
                    user.Password = value.UserInfo.Password;
                    user.DOB = value.UserInfo.DOB;
                    user.TypeID = value.UserInfo.TypeID;
                    user.Email = value.UserInfo.Email;
                    user.Gender = value.UserInfo.Gender;
                    user.Phone = value.UserInfo.Phone;
                    user.StatusID = value.UserInfo.StatusID;

                    if (user.FirstName == string.Empty)
                    {
                        error = "Invalid First Name";
                        return value;
                    }

                    else if (user.LastName == string.Empty)
                    {
                        error = "Invalid Last Name";
                        return value;
                    }

                    else if (user.Email == string.Empty)
                    {
                        error = "Invalid Email";
                        return value;
                    }
                    else if (user.Password == string.Empty)
                    {
                        error = "Invalid Password";
                        return value;
                    }
                    else if (user.Phone == string.Empty)
                    {
                        error = "Invalid phone num";
                        return value;
                    }
             
                    _context.SaveChanges();

                    if (employee == null)
                    {
                        employee = new EmployeeInfo();
                        _context.EmployeeInfoes.Add(employee);
                    }

                    employee.ID = user.ID;
                    employee.JoinDate = value.JoinDate;
                    employee.DeptID = value.DeptID;
                    employee.DesiID = value.DesiID;

                    _context.SaveChanges();

                    scope.Commit();

                    employee.UserInfo = user;
                    return employee;
                }
                catch (Exception e)
                {
                    error = e.Message;
                    scope.Rollback();
                    return value;
                }
            }
        }
    }
}