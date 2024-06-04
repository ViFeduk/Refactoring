using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    internal interface IAccount
    {
        double Balance { get; set; }

        // процентная ставка
        double Interest { get; }

        // Метод для расчета процентной ставки
        void CalculateInterest();
    }
}
