using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MockDataLayer : PersonData
    {
        private List<Person> persons;

        public MockDataLayer()
        {
            persons = new List<Person>();
            persons.Add(new Person() { Name = "Person 1"});
            persons.Add(new Person() { Name = "Person 2"});
        }

        public async Task AddPerson(Person p)
        {
            persons.Add(p);
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return persons;
        }

        public async Task RemovePerson(Person p)
        {
            this.persons.Remove(p);
        }
    }
}
