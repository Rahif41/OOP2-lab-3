using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            studebt s1 = new student();
            s1.setName("Rahif");
            s1.setCgpa(3);
            s1.setDepartment("CSE");
            s1.setId("18-36365-1");
            s1.showInfo();
            Console.WriteLine();
            Triangle t1 = new Triangle();
            t1.setX(4);
            t1.setY(5);
            t1.setX(4);
            t1.TestTriangle();
            Course c1 = new Course();
            c1.setCourseName("OOP2");
            c1.setCourseName("1125");
            c1.setCourseCredit(3);

            Account a1 new Account();
            a1.setBalance("2000");
            a1.AccName("Rahif");
            a1.setAcid("150");
            a1.Deposite("2000");
            Console.WriteLine(a1.getBalance());

            a1.withdraw(3000);
            Console.WriteLine(a1.getBalance());

        }
    }
}
