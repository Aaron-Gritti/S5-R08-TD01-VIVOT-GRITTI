using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace TestViewModels
{
    public class TestPersonVM
    {
        private Person CreatePerson()
        {
            return new Person() { Id = 1, Name = "Toto", Phone = "123456" };
        }

        [Fact]
        public void TestCreate()
        {
            Person person = CreatePerson();
            PersonVM test = new PersonVM(person);
            Assert.Same(person, test.Model);
        }

        [Fact]
        public void TestName()
        {
            Person person = CreatePerson();
            PersonVM test = new PersonVM(person);
            Assert.Equal(person.Name, test.Name);
            var name = "change";
            test.Name = name;
            Assert.Equal(name, person.Name);           
        }

        [Fact]
        public void TestPhone() 
        {
            Person person = CreatePerson();
            PersonVM test = new PersonVM(person);
            Assert.Equal(person.Phone, test.Phone);
            var phone = "9875";
            test.Phone = phone;
            Assert.Equal(phone, person.Phone);
        }
    }
}
