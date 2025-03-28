using ConsoleApp1.ConsoleApp1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("AB109", 10);

            Student student1 = new Student(1, "Farhadli Aysun", 94);
            Student student2 = new Student(2, "Mammadov Mustafa", 100);
            Student student3 = new Student(3, "Ahmadzada Ayan", 88);

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);

            Console.WriteLine("Qrupdakı bütün tələbələr:");
            Student[] students = group.GetAllStudents();
            foreach (var student in students)
            {
                student.StudentInfo();
            }

            Console.WriteLine("\nID-si 2 olan tələbənin məlumatları:");
            Student foundStudent = group.GetStudent(2);
            if (foundStudent != null)
                foundStudent.StudentInfo();
            else
                Console.WriteLine("Melumat tapilmadi.");





        }
    }
}
