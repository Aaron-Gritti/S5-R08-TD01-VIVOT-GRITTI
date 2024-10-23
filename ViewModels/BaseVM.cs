
using System.ComponentModel;

namespace ViewModels
{
    /// <summary>
    /// Base of view-models
    /// </summary>
    public class BaseVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Notify a property has changed (if event linked)
        /// </summary>
        /// <param name="propName">name of property who changed</param>
        protected void NotifyPropChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }

}
