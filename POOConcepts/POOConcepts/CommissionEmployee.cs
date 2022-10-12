using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPorcentaje { get; set; }

        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPorcentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
            $"\n\tCommissionPorcentaje: {$"{CommissionPorcentaje:P2}", 15}" +
            $"\n\tSales...............: {$"{Sales:C2}", 15}" + 
            $"\n\tValue to pay........: {$"{GetValueToPay():C2}", 15}";
        }
    }
}
