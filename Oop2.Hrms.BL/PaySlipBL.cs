using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oop2.Hrms.Data;

namespace Oop2.Hrms.BL
{
    public class PaySlipBL
    {
        private HRDBEntities _context = new HRDBEntities();


        public List<PaySlip> GetAll(string key = "")
        {
            IEnumerable<PaySlip> query = _context.PaySlips;

            if (!string.IsNullOrEmpty(key))
            {
                int id;
                if (Int32.TryParse(key, out id))
                {
                    query = query.Where(q => q.ID == id);
                }
                else
                {
                    query =
                        query.Where(
                            q =>
                                q.EmployeeID.ToString() == key);
                }
            }
            return query.ToList();
        }

        public bool Delete(int id, out string error)
        {
            error = string.Empty;

            var paySlip = _context.PaySlips.FirstOrDefault(u => u.ID == id);

            if (paySlip == null)
            {
                error = "Invalid Department ID";
                return false;
            }

            try
            {
                _context.PaySlips.Remove(paySlip);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }

            return true;
        }

        public PaySlip Save(PaySlip value, out string error)
        {
            error = string.Empty;
            try
            {
                var paySlip = _context.PaySlips.FirstOrDefault(u => u.ID == value.ID);

                if (paySlip == null)
                {
                    paySlip = new PaySlip();
                    _context.PaySlips.Add(paySlip);
                }

                paySlip.ID = value.ID;
                paySlip.EmployeeID = value.EmployeeID;
                paySlip.PayrolID = value.PayrolID;
                paySlip.Basic = value.Basic;
                paySlip.HouseAlignment = value.HouseAlignment;
                paySlip.MedicalFacilities = value.MedicalFacilities;
                paySlip.Addition = value.Addition;
                paySlip.Deduction = value.Deduction;

                if (paySlip.EmployeeID.ToString() == string.Empty)
                {
                    error = "Invalid EmployeeID";
                    return value;
                }

                _context.SaveChanges();
                return paySlip;
            }
            catch (Exception e)
            {
                error = e.Message;
                return value;
            }
        }

    }
}