using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oop2.Hrms.Data;

namespace Oop2.Hrms.BL
{
    public class PayRolBL
    {
        private HRDBEntities _context = new HRDBEntities();


        public List<PayRol> GetAll(string key = "")
        {
            IEnumerable<PayRol> query = _context.PayRols;

            if (!string.IsNullOrEmpty(key))
            {
                int id;
                if (Int32.TryParse(key, out id))
                {
                    query = query.Where(q => q.ID == id);
                }
                else
                {
                    query = query.Where(q => q.Name.Contains(key) || q.Month.ToString() == key || q.Year.ToString() == key);
                }
            }
            return query.ToList();
        }

        public bool Delete(int id, out string error)
        {
            error = string.Empty;

            var payRol = _context.PayRols.FirstOrDefault(u => u.ID == id);

            if (payRol == null)
            {
                error = "Invalid Payroll ID";
                return false;
            }

            try
            {
                _context.PayRols.Remove(payRol);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }

            return true;
        }

        public PayRol Save(PayRol value, out string error)
        {
            error = string.Empty;
            try
            {
                var payRol = _context.PayRols.FirstOrDefault(u => u.ID == value.ID);

                if (payRol == null)
                {
                    payRol = new PayRol();
                    _context.PayRols.Add(payRol);
                }

                payRol.Name = value.Name;
                payRol.Month = value.Month;
                payRol.Year = value.Year;

                if (payRol.Name == string.Empty)
                {
                    error = "Invalid Institute Name";
                    return value;
                }

                _context.SaveChanges();
                return payRol;
            }
            catch (Exception e)
            {
                error = e.Message;
                return value;
            }
        }

    }
}