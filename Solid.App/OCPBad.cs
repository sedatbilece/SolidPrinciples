using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCPBad.Bad
{

    public enum SalaryType
    {
        Low,
        Medium,
        High
    }
    // enum içine yeni alan eklendiğinde ilgili fonksiyona da eklemek gerekiyor .

    public class SalaryCalculator
    {
        public decimal Calculator(decimal salary, SalaryType salaryType)
        {
            decimal newSalary = 0;


            switch (salaryType)
            {
                    case SalaryType.Low:
                    newSalary = salary * 2;
                    break;
                    case SalaryType.Medium:
                    newSalary = salary * 4;
                    break;
                    case SalaryType.High:
                    newSalary = salary * 6;
                    break;
                    default:
                    break;
            }

            return newSalary;
        }
    }

}
