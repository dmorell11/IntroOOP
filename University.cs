using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    internal class University
    {
        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }
        public List<Classroom> Classrooms { get; private set; }
        public Animal Pet { get; private set; }

        public University(Animal pet, List<(string name, int capacity)> classroomDetails)
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Classrooms = new List<Classroom>();
            Pet = pet;

            foreach (var classroomDetail in classroomDetails)
            {
                Classrooms.Add(new Classroom(classroomDetail.name, classroomDetail.capacity));
            }

            Console.WriteLine($"University created with {classroomDetails.Count} classrooms and {pet.Name} as a mascot");
        }

        public bool AddNewStudent(Student newStudent)
        {
            if (newStudent.Age >= 18)
            {
                Students.Add(newStudent);
                Console.WriteLine($"Student {newStudent.Name} successfully added to the university");
                return true;
            }
            else
            {
                Console.WriteLine($"Error: Student {newStudent.Name} is underage and cannot be added to the university");
                return false;
            }
        }

        public bool AddNewTeacher(Teacher newTeacher)
        {
            Teachers.Add(newTeacher);
            Console.WriteLine($"Teacher {newTeacher.Name} successfully added to the university");
            return true;
        }

        public bool AssignStudentToClassroom(Student student, Classroom classroom)
        {
            if (!Students.Contains(student))
            {
                Console.WriteLine($"Error: Student {student.Name} is not registered in the university");
                return false;
            }

            return classroom.AddStudent(student);
        }

        public bool AssignTeacherToClassroom(Teacher teacher, Classroom classroom)
        {
            if (!Teachers.Contains(teacher))
            {
                Console.WriteLine($"Teacher {teacher.Name} is not registered in the university");
                return false;
            }

            return classroom.AddTeacher(teacher);
        }

        public bool ChangePet(Animal newPet)
        {
            Pet = newPet;
            return true;
        }
    }
}
