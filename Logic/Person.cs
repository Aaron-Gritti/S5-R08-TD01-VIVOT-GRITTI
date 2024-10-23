using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// A simple Person
    /// </summary>
    public class Person
    {

        private int id = 0;
        private string name = string.Empty;
        private string phone = string.Empty;

        /// <summary>
        /// Gets or sets the id of a person
        /// </summary>
        public int Id 
        { 
            get => id; 
            set => id = value;
        }


        /// <summary>
        /// Gets or sets the name of a person
        /// </summary>
        public string Name 
        { 
            get => name;
            set => name = value; 
        }

        /// <summary>
        /// Gets or sets the phone number of a person
        /// </summary>
        public string Phone 
        { 
            get => phone; 
            set => phone = value; 
        }


        /// <summary>
        /// Constructor of a person
        /// </summary>
        public Person()
        {

        }
    }
}
