using Classes.Models;
using System.Reflection;

Student[] arrOfStudents = new Student[5];
arrOfStudents[0] = new Student("Kiril", "SEDC", "G2");
arrOfStudents[1] = new Student("Stefan", "SEDC", "G3");
arrOfStudents[2] = new Student("Steve", "SEDC", "G4");
arrOfStudents[3] = new Student("Nikola", "SEDC", "G5");
arrOfStudents[4] = new Student("Zoran", "SEDC", "G6");

string searchStudent()
{
    Console.WriteLine("Enter a name, to check if he is a student");
    string searchName = Console.ReadLine();
    string studentSpecs = "That student does not exist";
    foreach (Student student in arrOfStudents)
    {
        if (student.Name == searchName)
        {
            studentSpecs = $"Stats of the Student:\nName:{student.Name}\nAcademy: {student.Academy}\nGroup: {student.Group}";
            break;
        }
    };
    Console.WriteLine(studentSpecs);
    return studentSpecs;
}
searchStudent();
