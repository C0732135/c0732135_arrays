using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0732135_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StudentInformation Mary=new StudentInformation ("Mary",3.8,20);
            StudentInformation John = new StudentInformation("John", 2.0, 10);
            StudentInformation Mark = new StudentInformation("Mark", 0.2, 3);
            StudentInformation Steve = new StudentInformation("Steve", 2.9, 16);
            StudentInformation Cindy = new StudentInformation("Cindy", 3.9, 187);
            var StudentList = new List<StudentInformation>();
            StudentList.Add(Mary);
            StudentList.Add(John);
            StudentList.Add(Mark);
            StudentList.Add(Steve);
            StudentList.Add(Cindy);

            foreach(var student in StudentList)
            {
                Console.WriteLine(student.name);
            }



        }
    }
    class StudentInformation
    {
       public string name;
        
        public double gpa;
        public int Attendance;
        public StudentInformation(string aname, double agpa, int aAttendance)
        {
            name = aname;

            gpa = agpa;

            Attendance = aAttendance;
        }
    }
  
}
