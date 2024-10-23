using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace TestViewModels
{
    public class TestDirectoryVM
    {
        [Fact]
        public void TestInit()
        {
            var data = new SpyPersonData();
            var vm = new DirectoryVM(data);
            Assert.Equal("get", data.LastAction);
            Assert.Null(vm.CurrentPerson);
            Assert.NotEmpty(vm.People);
        }

        [Fact]
        public async Task TestAdd()
        {
            var data = new SpyPersonData();
            var vm = new DirectoryVM(data);
            PersonVM test = new PersonVM(new Logic.Person() { Id = 1, Name = "toto", Phone = "1" });
            await vm.AddPerson(test);
            Assert.Equal("add", data.LastAction);
            Assert.Equal("toto", data.LastPerson?.Name);
            Assert.Contains(test, vm.People);
        }

        [Fact]
        public async Task TestRemove()
        {
            var data = new SpyPersonData();            
            var vm = new DirectoryVM(data);
            var test = vm.People.First();
            vm.CurrentPerson = test;
            await vm.RemovePerson();
            Assert.DoesNotContain(test, vm.People);
            Assert.Equal("remove", data.LastAction);
            Assert.Equal("toto", data.LastPerson?.Name);
        }
    }
}
