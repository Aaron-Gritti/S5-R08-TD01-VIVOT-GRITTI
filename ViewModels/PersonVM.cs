using Logic;

namespace ViewModels
{
    public class PersonVM : BaseVM
    {
        private string name;
        private string phone;
        private Person model;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                model.Name = value;
                NotifyPropChanged(Name);
            }
        }

        public string Phone
        {
            get => phone;
            set
            {
                phone = value;
                model.Phone = value;
                NotifyPropChanged(Phone);
            }
        }

        public Person Model 
        { 
            get => model; 
            set => model = value; 
        }


        public PersonVM(Person model)
        {
            this.model = model;
            this.name = model.Name;
            this.phone = model.Phone;
        }
    }
}
