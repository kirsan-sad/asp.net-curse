using StydentsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsLibrary
{
    interface IStudies
    {
        void Add(Student student);

        void AddStudentsToCourse(List<Student> list);
    }
}
