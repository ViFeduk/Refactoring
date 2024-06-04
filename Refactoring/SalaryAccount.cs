using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    internal class SalaryAccount : IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; private set; }

        public void CalculateInterest()
        {
            // расчет процентной ставки зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }


    }
}
