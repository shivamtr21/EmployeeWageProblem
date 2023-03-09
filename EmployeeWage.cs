using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageCaseProblem
{
    public class EmployeeWage
    {
        public static void TotalWage()
        {
            int Is_Present = 1;
            int Wage_Per_Hrs = 20;
            int EmpHrs = 0;

            int Total_Wage = 0;

            Random random = new Random();
            int num = random.Next(2);

            if (num == Is_Present)
            {
                Console.WriteLine("Employee is present");
                EmpHrs = 8;
            }

            else
            {
                Console.WriteLine("Employee is Absent");
                EmpHrs = 0;
            }

            Total_Wage = (EmpHrs * Wage_Per_Hrs);
            Console.WriteLine(Total_Wage);
        }
    }
}
