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
    }
}
