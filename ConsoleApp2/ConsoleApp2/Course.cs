using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;
        public string getCourseName()
        {
            return courseName;
        }
        public void setCourseName(string CourseName)
        {
            courseName = CourseName;
        }
        public string getCourseCode()
        {
            return courseName;
        }
        public void setCourseCode(string CourseCode)
        {
            courseCode = CourseCode;

        }
        public int getCourseCredit()
        {
            return courseCredit;
        }
        public void setCourseCredit(int CourseCredit)
        {
            courseCredit = CourseCredit;
        }
        public void Showinfo()
        {
            Console.WriteLine("Name : " + coursename);
            Console.WriteLine("Code : " + courseCode);
            Console.WriteLine("Credit : " + CourseCredit);
        }
    }
}
