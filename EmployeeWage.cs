using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageCaseProblem
{
    public class EmployeeWage
    {
        public static void CheckEmployeePresent()
        {
            int Is_Present = 1;

            Random random = new Random();
            int num = random.Next(2);

            if (num == Is_Present)
            {
                Console.WriteLine("Employee is present");
            }

            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
