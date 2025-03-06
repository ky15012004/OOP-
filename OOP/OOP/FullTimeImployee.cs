using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class FullTimeImployee : Employee
    {
        public FullTimeImployee(string Name_224, int PaymentPerHour_224) : base(Name_224, PaymentPerHour_224)
        {

        }
        public override int CalculateSalary()
        {
            return 8 * this.GetPaymentPerHour();
        }
    }
}
