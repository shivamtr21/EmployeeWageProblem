using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageCaseProblem
{
    public class EmployeeWage
    {
        public static void MaxDaysMaxHoursWage()
        {
            int Max_Days = 20;
            int Max_Hours = 100;


            int Wage_Per_hrs = 20;
            int EmpHrs = 0;

            int Total_Wage = 0;


            int Total_Work_Hour = 0;
            int day = 1;


            while (day <= Max_Days && Total_Work_Hour <= Max_Hours)
            {
                Random random = new Random();

                int num = random.Next(3);

                switch (num)
                {
                    case 0:
                        Console.WriteLine("Employee Is Absent");
                        EmpHrs = 0;
                        break;

                    case 1:
                        Console.WriteLine("Employee Is Present For Full Time");
                        EmpHrs = 8;
                        break;

                    case 2:
                        Console.WriteLine("Employee Is Present For Part Time");
                        EmpHrs = 4;
                        break;

                }
                day++;

                Total_Work_Hour = (Total_Work_Hour + EmpHrs);
                Total_Wage = (Total_Work_Hour * Wage_Per_hrs);

            }

            Console.WriteLine("Total Work Hour Is " + Total_Work_Hour);
            Console.WriteLine("Total Salary For A Month Is " + Total_Wage);





        }
    }
}
