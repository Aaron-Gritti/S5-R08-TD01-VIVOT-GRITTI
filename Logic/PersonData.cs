using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Interface of a Person
    /// </summary>
    public interface PersonData
    {

        /// <summary>
        /// Gets the list of all persons
        /// </summary>
        /// <returns>The list of persons</returns>
        public Task<IEnumerable<Person>> GetAll();

        /// <summary>
        /// Adds a person to the list of persons
        /// </summary>
        /// <param name="p">The person to add</param>
        public Task AddPerson(Person p);

        /// <summary>
        /// Removes a person from the list of persons
        /// </summary>
        /// <param name="p">The person to remove</param>
        public Task RemovePerson(Person p);
    }
}
