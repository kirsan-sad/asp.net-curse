using StydentsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsLibrary
{
    public interface IStudies
    {
        void Add(Student student);

        List<Student> AddStudentsToCourse(List<Student> list);

        Student GetStudent(int index);
    }
}
