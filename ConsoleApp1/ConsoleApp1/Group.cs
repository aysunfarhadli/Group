using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit { get; set; }
        private Student[] Students;
        private int studentCount;
        public Group(string groupNo, int studentLimit)
        {
            if (CheckGroupNo(groupNo))
            {
                GroupNo = groupNo;
                if (studentLimit >= 5 && studentLimit <= 18)
                {
                    StudentLimit = studentLimit;
                }
                else
                {
                    Console.WriteLine(" tələbə sayını minumum 5 maximum 18 ola bilər");
                    return;
                }
            }
        }
        public bool CheckGroupNo(string groupNo)
        {
            return groupNo.Length == 5 &&
                char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) &&
                char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]);
        }
        public void AddStudent(Student student)
        {
            if (studentCount < StudentLimit)
            {
                Students[studentCount++] = student;
            }
            else
            {
                Console.WriteLine("Qrup doludur");
            }
        }
        public Student GetStudent(int id)
        {

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                    return Students[i];
            }
            return null;
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }
    }
}
