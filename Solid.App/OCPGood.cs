using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCPBad.Good
{
    // switch blokları ve enum almak open closed ihlalleine genellikle neden olabilir.


    public interface ISalaryCalculate
    {
        decimal Calculate(decimal salary);
    }

    public class LowSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }

    public class MediumSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }

    public class HighSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }



    public class SalaryCalculator
    {
        public decimal Calculator(decimal salary , ISalaryCalculate salaryCalculate)
        {

            return salaryCalculate.Calculate(salary);
        }
    }

}
