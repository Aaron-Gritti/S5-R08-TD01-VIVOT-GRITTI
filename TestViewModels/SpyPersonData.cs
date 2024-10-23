using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestViewModels
{
    /// <summary>
    /// Spy class to test view model layer
    /// </summary>
    internal class SpyPersonData : PersonData
    {
        private string? lastAction;
        private Person? lastPerson;

        /// <summary>
        /// Gets the last action
        /// </summary>
        public string? LastAction => lastAction;
        /// <summary>
        /// Gets the last person used
        /// </summary>
        public Person? LastPerson => lastPerson;
        public async Task AddPerson(Person person)
        {
            lastAction = "add";
            lastPerson = person;
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            lastAction = "get";
            lastPerson = new Person() { Id = 1, Name = "toto", Phone = "01" };            
            return [lastPerson,new Person() { Id = 2, Name = "tata", Phone = "34" }];
        }

        public async Task RemovePerson(Person person)
        {
            lastAction = "remove";
            lastPerson = person;
        }
    }
}
