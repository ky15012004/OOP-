using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Employee : IEployee
    {
        string Name_224;
        int PaymentPerHour_224;

        public Employee(string Name_224, int PaymentPerHour_224)
        {
            this.Name_224 = Name_224;
            this.PaymentPerHour_224 = PaymentPerHour_224; 
        }

        public void SetName(string Name_224)
        {
            this.Name_224 = Name_224;
        }


        public string GetName()
        {
           return Name_224;
        }

        public void SetPaymentPerHour(int PaymentPerHour_224)
        {
            this.PaymentPerHour_224 = PaymentPerHour_224;
        }


        public int GetPaymentPerHour()
        {
            return PaymentPerHour_224;
        }

        public abstract int CalculateSalary();
    }
}
