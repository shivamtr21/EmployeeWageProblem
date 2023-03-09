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
            int Is_Present_Full_Time = 1;
            int Is_Present_Part_Time = 2;
            int Wage_Per_Hrs = 20;
            int EmpHrs = 0;

            int Total_Wage = 0;

            Random random = new Random();
            int num = random.Next(3);

            if (num == Is_Present_Full_Time)
            {
                Console.WriteLine("Employee is present for full time");
                EmpHrs = 8;
            }
            else if(num == Is_Present_Part_Time)
            {
                Console.WriteLine("Employee is present for part time");
                EmpHrs = 4;
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
