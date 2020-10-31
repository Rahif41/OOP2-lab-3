using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class student
    {
        string name;
        string id;
        string department;
        float cgpa;
        public string getName()
        {
            return name;
        }
        public void setName(string Name)
        {
            name = Name;
        }
        public string getId()
        {
            return id;
        }
        public void setId(string Id)
        {
            id = Id;
        }
        public string getdept()
        {
            return department;
        }
        public void setDepartment(string Department)
        {
            department = Department;
        }
        public float getCgpa()
        {
            return cgpa;
        }
        public void setCgpa(float cgpa)
        {
            cgpa = cgpa;
        }
        public void setInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("Cgpa : " + cgpa);

        }
    }
}
