using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oop2.Hrms.Data;

namespace Oop2.Hrms.BL
{
    public class EmployeeSalaryBL
    {
        private HRDBEntities _context = new HRDBEntities();


        public List<EmployeeSalary> GetAll(string key = "")
        {
            IEnumerable<EmployeeSalary> query = _context.EmployeeSalaries;

            if (!string.IsNullOrEmpty(key))
            {
                int id;
                if(Int32.TryParse(key, out id))
                {
                    query = query.Where(q => q.EmployeeID == id);
                }
                else
                {
                    query =
                        query.Where(
                            q =>
                                q.ID.ToString() ==key);
                }
            }
            return query.ToList();
        }

        public bool Delete(int id, out string error)
        {
            error = string.Empty;

            var empSal = _context.EmployeeSalaries.FirstOrDefault(u => u.ID == id);

            if (empSal == null)
            {
                error = "Invalid Employee ID";
                return false;
            }

            try
            {
                _context.EmployeeSalaries.Remove(empSal);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }

            return true;
        }

        public EmployeeSalary Save(EmployeeSalary value, out string error)
        {
            error = string.Empty;
            try
            {
                var empSal = _context.EmployeeSalaries.FirstOrDefault(u => u.ID == value.ID);

                if (empSal == null)
                {
                    empSal = new EmployeeSalary();
                    _context.EmployeeSalaries.Add(empSal);
                }

                empSal.EmployeeID = value.EmployeeID;
                empSal.Basic = value.Basic;
                empSal.HouseAlignment = value.HouseAlignment;
                empSal.MedicalFacilities = value.MedicalFacilities;
                empSal.IsCurrent = value.IsCurrent;
           

                if (!_context.EmployeeInfoes.Any(e=>e.ID==value.EmployeeID))
                {
                    error = "Invalid Employee ID";
                    return value;
                }

                //if (empSal.IsCurrent)
                //{
                    
                //}

                _context.SaveChanges();
                return empSal;
            }
            catch (Exception e)
            {
                error = e.Message;
                return value;
            }
        }

    }
}