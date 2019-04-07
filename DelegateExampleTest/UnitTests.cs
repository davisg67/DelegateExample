using System;
using DelegateExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DelegateExampleTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void EmployeeList()
        {
            //Arrange
            List<Employee> list = new List<Employee>();

            //Act
            list = Program.GetEmployeeList();

            //Assert
            Assert.AreEqual(list.Count, 3);
        }

        [TestMethod]
        public void PromoteSuccess()
        {
            //Arrange
            Employee emp = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };

            //Act
            bool result = Program.Promote(emp);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PromoteFail()
        {
            //Arrange
            Employee emp = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Experience = 5,
                Salary = 10000
            };

            //Act
            bool result = Program.Promote(emp);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
