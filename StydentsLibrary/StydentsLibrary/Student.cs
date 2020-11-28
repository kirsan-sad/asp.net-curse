using StudentsLibrary;
using System;
using System.Collections.Generic;

namespace StydentsLibrary
{
    public class Student : IStudies
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Courses Course { get; set; }


        List<Student> students = null;

        public void Add(Student student)
        {
            students.Add(student);
        }

        public List<Student> AddStudentsToCourse(List<Student> list)
        {
            foreach (var student in list)
            {
                student.Course.CourseId = 1;
                student.Course.Name = "Math";
            }

            return list;
        }

        public Student GetStudent(int index)
        {
            throw new NotImplementedException();
        }
    }
}
