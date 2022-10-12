using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }

        public decimal HoursValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HoursValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
            $"\n\tHours...............: {$"{Hours:N2}", 15}" +
            $"\n\tHoursValue..........: {$"{HoursValue:C2}",15}" +
            $"\n\tValue to pay........: {$"{GetValueToPay():C2}",15}";
        }
    }
}
