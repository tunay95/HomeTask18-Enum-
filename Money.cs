using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask18_Enum_
{
    internal class Money
    {
        public double Value { get; set; }
        public CurrencyEnum Currency { get; set; }

        public Money(double value, CurrencyEnum currency)
        {
            Value = value;
            Currency = currency;
        }
    }
}
