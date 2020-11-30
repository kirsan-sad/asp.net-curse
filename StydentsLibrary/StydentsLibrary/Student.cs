using StudentsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StydentsLibrary
{
    public class Student : IStudies
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Courses Course { get; set; }


        List<Student> students = null;
        Courses math = new Courses { CourseId = 1, Name = "Math" };

        public void Add(Student student)
        {
            students.Add(student);
        }

        public List<Student> AddStudentsToCourse(List<Student> list)
        {
            foreach (var student in list)
            {
                student.Course = math;
            }

            return list;
        }

        public Student GetStudent(int index)
        {
            throw new NotImplementedException();
        }

        public string SayHello(string name, int age)
        {
            string lastName = GetName();

            return $"Hello {lastName}";
        }

        public virtual string GetName()
        {
            return "Nik";
        }

        public string ShowStudentById(List<Student> list, int id)
        {
            var name = list.Where(x => x.StudentId == id);

            string temp = "";

            foreach (var item in name)
            {
                temp = item.Name;
            }

            return temp;
        }
    }
}
