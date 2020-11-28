using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StudentsLibrary;
using StydentsLibrary;
using System;
using System.Collections.Generic;

namespace StudentUnitTest
{
    [TestClass]
    public class StudentTest1
    {
        [TestMethod]
        public void GetStudent_Index()
        {
            // Arrange
            var mock = new Mock<IStudies>();
            Student[] students = {new Student () };

            // Act
            mock.Setup(m => m.GetStudent(1)).Returns(students[0]);

            // Assert
            IStudies stud = mock.Object;
            Student s0 = stud.GetStudent(0);
            Student s1 = stud.GetStudent(1);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Студентов нет")]
        public void AddStudentsToCourse_Null_Message()
        {
            // Arrange
            var stud = new Student();
            //var s1 = new Student("Bill", 2);
            List<Student> students = null;
            // Act

            
            var actual = stud.AddStudentsToCourse(students);

            // Assert
            
        }
    }
}
