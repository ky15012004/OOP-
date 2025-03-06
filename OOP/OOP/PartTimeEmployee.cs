using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class PartTimeEmployee : Employee
    {
        int WorkingHours_224;

        public PartTimeEmployee(int PaymentPerHour_224, string name_224 ,int WorkingHours_224)  : base(name_224, PaymentPerHour_224)
        {
            this.WorkingHours_224 = WorkingHours_224;
        }
        
        public override int CalculateSalary()
        {
            return WorkingHours_224 * this.GetPaymentPerHour();
        }


    }
}
