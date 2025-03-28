namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("AB109", 10);


            Student student1 = new Student(1, "Aysun Ferhadli", 75);
            Student student2 = new Student(2, "Abbas Abbasov", 90);
            Student student3 = new Student(3, "Əliyev eli ", 77);

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);


            Console.WriteLine("Qrupdakı bütün tələbələr:");
            Student[] allStudents = group.GetAllStudents();
            foreach (var student in allStudents)
            {

                student.StudentInfo();
            }


            Console.WriteLine("ID-si 2 ");
            Student foundStudent = group.GetStudent(2);
            if (foundStudent != null)
            {
                foundStudent.StudentInfo();
            }
            else
            {
                Console.WriteLine("yoxdu.");
            }
        }
    }
}
