using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oop2.Hrms.Data;

namespace Oop2.Hrms.BL
{
    public class DeptInfoBL
    {
        private HRDBEntities _context = new HRDBEntities();


        public List<DeptInfo> GetAll(string key = "")
        {
            IEnumerable<DeptInfo> query = _context.DeptInfoes;

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
                                q.Name.Contains(key));
                }
            }
            return query.ToList();
        }

        public bool Delete(int id, out string error)
        {
            error = string.Empty;

            var department = _context.DeptInfoes.FirstOrDefault(u => u.ID == id);

            if (department == null)
            {
                error = "Invalid Department ID";
                return false;
            }

            try
            {
                _context.DeptInfoes.Remove(department);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }

            return true;
        }

        public DeptInfo Save(DeptInfo value, out string error)
        {
            error = string.Empty;
            try
            {
                var department = _context.DeptInfoes.FirstOrDefault(u => u.ID == value.ID);

                if (department == null)
                {
                    department = new DeptInfo();
                    _context.DeptInfoes.Add(department);
                }

                department.Name = value.Name;

                if (department.Name == string.Empty)
                {
                    error = "Invalid Department Name";
                    return value;
                }

                _context.SaveChanges();
                return department;
            }
            catch (Exception e)
            {
                error = e.Message;
                return value;
            }
        }

    }
}