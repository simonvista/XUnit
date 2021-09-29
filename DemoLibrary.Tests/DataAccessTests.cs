using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;
using DemoLibrary.Models;

namespace DemoLibrary.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModel newPerson = new PersonModel
            {
                FirstName = "John",
                LastName = "Doe"
            };
            List<PersonModel> person = new List<PersonModel>();
            DataAccess.AddPersonToPeopleList(person, newPerson);
            Assert.True(person.Count == 1);
            Assert.Contains<PersonModel>(newPerson, person);
        }
        [Theory]
        [InlineData("Tim", "", "LastName")]
        [InlineData("","Corey","FirstName")]
        public void AddPersonToPeopleList_ShouldThrowError(string firstName, string lastName, string param)
        {
            PersonModel newPerson = new PersonModel
            {
                FirstName = firstName,
                LastName = lastName
            };
            List<PersonModel> person = new List<PersonModel>();
            //DataAccess.AddPersonToPeopleList(person, newPerson);
            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(person, newPerson));
            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(person, newPerson));
        }
    }
}
