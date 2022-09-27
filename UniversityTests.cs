using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;

namespace MyTests
{
    internal class UniversityTests
    {
        [Test]
        public void CheckCreateStudent()
        {
            var student = new Student(1, "Jan");
            Assert.IsInstanceOf(typeof(Student), student);
            Assert.IsTrue(student.Id == 1 && student.Name == "Jan");
        }

        [Test]
        public void CheckCreateDepartment()
        {
            var student1 = new Student(1, "Jan");
            var student2 = new Student(2, "Aga");

            var students = new List<Student>();
            students.Add(student1); 
            students.Add(student2);

            var department = new Department(1, "Fizyka", students);
            Assert.IsInstanceOf(typeof(Department), department);
            Assert.IsTrue(department.Id == 1 && department.Name == "Fizyka" && 
                department.Students.Any(s => s.Id == 1 && s.Name == "Jan") && 
                department.Students.Any(s => s.Id == 2 && s.Name == "Aga"));

        }

        [Test]
        public void CheckCreateUniversity()
        {
            var student1 = new Student(1, "Jan");
            var student2 = new Student(2, "Aga");

            var students = new List<Student>();
            students.Add(student1);
            students.Add(student2);

            var department1 = new Department(1, "Fizyka", students);
            var department2 = new Department(2, "Informatyka", students);
            var departments = new List<Department>();
            departments.Add(department1);
            departments.Add(department2);

            var university = new University(1, "Uczelnia", departments);
            Assert.IsInstanceOf(typeof (University), university);
            Assert.IsTrue(university.Id == 1 && university.Name == "Uczelnia" && 
                university.Departments.Any(d => d.Id == 1 && d.Name == "Fizyka" && 
                d.Students.Any(s => s.Id == 1 && s.Name == "Jan") && 
                university.Departments.Any(d => d.Id == 1 && d.Name == "Fizyka" && 
                d.Students.Any(s => s.Id == 2 && s.Name == "Aga"))&&
                university.Departments.Any(d => d.Id == 2 && d.Name == "Informatyka" &&
                d.Students.Any(s => s.Id == 1 && s.Name == "Jan") && 
                university.Departments.Any(d => d.Id == 2 && d.Name == "Informatyka" &&
                d.Students.Any(s => s.Id == 2 && s.Name == "Aga")))));

        }
    }
}
