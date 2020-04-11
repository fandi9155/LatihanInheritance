using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Fidya", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Gendis", 30,"1911", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Prihartiningsih",19,"19112813",
"fidya.1999@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
