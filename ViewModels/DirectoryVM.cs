using Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class DirectoryVM : BaseVM
    {
        private ObservableCollection<PersonVM> people;
        private PersonVM currentPerson;
        private PersonData data;


        public PersonVM CurrentPerson { get => currentPerson; set => currentPerson = value; }
        public ObservableCollection<PersonVM> People { get => people; set => people = value; }

        public DirectoryVM(PersonData data) 
        { 
            this.people = new ObservableCollection<PersonVM>();
            this.data = data;
            Init(data);
        }

        private async void Init(PersonData data)
        {
            IEnumerable<Person> people = await data.GetAll();
            foreach (Person person in people)
            {
                this.people.Add(new PersonVM(person));
            }
        }

        public async Task AddPerson(PersonVM personVM)
        {

        }

        public async Task RemovePerson()
        {

        }
    }
}
