using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StudentsLibrary;
using StydentsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public void AddStudentsToCourse_NullList_NullReferenceException()
        {
            // Arrange
            var stud = new Student();
            List<Student> students = null;

            // Act
            var actual = stud.AddStudentsToCourse(students);

            // Assert
            
        }

        [TestMethod]
        public void AddStudentsToCourse_CourseName_Math()
        {
            // Arrange
            var stud = new Student();
            List<Student> students = new List<Student> {stud};

            // Act
            stud.AddStudentsToCourse(students);
            var actual = stud.Course.Name;

            // Assert
            Assert.AreEqual(actual, "Math");
        }

        [TestMethod]
        public void SayHello_ReurnName_Nik()
        {
            // Arrange
            string stringToReturn = "Nik";
            Mock<Student> name = new Mock<Student>();
            name.Setup(x => x.GetName()).Returns(stringToReturn);

            // Act
            var actual = name.Object.SayHello(It.IsAny<string>(), It.IsAny<int>());
            string expected = (actual);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void ShowStudentById_ReurnName_Nik()
        {
            // Arrange
            Mock<Student> name = new Mock<Student>();
            string expected = "Nik";
            int id = 2;

            // Act
            var actual = name.Object.ShowStudentById(stud, id);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        private List<Student> stud = new List<Student> {
            new Student {Name = "Mik", StudentId = 1},
            new Student {Name = "Nik", StudentId = 2},
        };
    }
}
