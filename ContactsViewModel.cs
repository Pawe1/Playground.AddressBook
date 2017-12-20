using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class ContactsViewModel : INotifyPropertyChanged
    {
        Contacts _contacts;

        void LoadFromFile(string fileName)
        {
            
        }

        System.Windows.Input.ICommand _LoadCommand;
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
