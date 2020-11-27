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

        public Student (string name, int studentId)
        {
            Name = name;
            StudentId = studentId;
        }

        List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void AddStudentsToCourse(List<Student> list)
        {
            foreach (var student in list)
            {
                student.Course.CourseId = 1;
                student.Course.Name = "Math";
            } 
        }
    }
}
