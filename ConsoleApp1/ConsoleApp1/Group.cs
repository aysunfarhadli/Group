using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

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
                        Students = new Student[StudentLimit];
                        studentCount = 0;
                    }
                    else
                    {
                        Console.WriteLine("Tələbə sayı minimum 5 maksimum 18 ola bilər.");
                    }
                }
                else
                {
                    Console.WriteLine("Qrup nömrəsi düzgün deyil! (məsələn: AB109)");
                }
            }

            public bool CheckGroupNo(string groupNo)
            {
                if (groupNo.Length != 5)
                    return false;

                return char.IsUpper(groupNo[0]) &&
                       char.IsUpper(groupNo[1]) &&
                       char.IsDigit(groupNo[2]) &&
                       char.IsDigit(groupNo[3]) &&
                       char.IsDigit(groupNo[4]);
            }

            public void AddStudent(Student student)
            {
                if (studentCount < StudentLimit)
                {
                    Students[studentCount] = student;
                    studentCount++;
                }
                else
                {
                    Console.WriteLine("Qrup doludur, əlavə edilə bilməz!");
                }
            }

            public Student GetStudent(int id)
            {
                for (int i = 0; i < studentCount; i++)
                {
                    if (Students[i].Id == id)
                        return Students[i];
                }

                return null;
            }

            public Student[] GetAllStudents()
            {
                Student[] allStudents = new Student[studentCount];

                for (int i = 0; i < studentCount; i++)
                {
                    allStudents[i] = Students[i];
                }

                return allStudents;
            }
        }
    }



}
    


