using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    internal class Calculator
    {
        public static void CalculatorInstance(IAccount account)
        {    
                account.CalculateInterest();
        }

    }
}
