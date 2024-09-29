using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    internal class Classroom
    {
        public string Name { get; private set; }
        public List<Student> Students { get; private set; }
        public Teacher Teacher { get; private set; }
        public int MaxCapacity { get; private set; }

        public Classroom(string name, int maxCapacity)
        {
            Name = name;
            Students = new List<Student>();
            MaxCapacity = maxCapacity;
        }

        public bool AddTeacher(Teacher teacher)
        {
            if (Teacher == null)
            {
                Teacher = teacher;
                Console.WriteLine($"Teacher {teacher.Name} successfully assigned to {Name} classroom");
                return true;
            }

            Console.WriteLine($"There is already a teacher assigned to {Name} classroom");
            return false;
        }

        public bool AddStudent(Student student)
        {
            if (Teacher == null)
            {
                Console.WriteLine($"Error: Cannot add student to the {Name} classroom without a teacher");
                return false;
            }

            if (Students.Count >= MaxCapacity)
            {
                Console.WriteLine($"Error: {Name} classroom is full. Cannot add student {student.Name}");
                return false;
            }

            Students.Add(student);
            Console.WriteLine($"Student {student.Name} successfully assigned to {Name} classroom");
            return true;
        }

        public string ListClassroomMembers()
        {
            string list = $"{Name} classroom (Max Capacity: {MaxCapacity}) - Teacher: {Teacher.Name}\n";
            list += "Students:\n";

            foreach (var student in Students)
            {
                list += student.ToString();
            }

            return list;
        }
    }
}
