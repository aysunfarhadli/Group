using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public double Point { get; set; }

        public Student(int id, string fullname, double point)
        {
            Id = id;
            Fullname = fullname;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Fullname}, Point: {Point}");
        }
    }
}
