using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; OnPropertyChanged("FirstName"); }
        }

        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; OnPropertyChanged("LastName"); }
        }

        private DateTime _DayOfBirth;

        public DateTime DayOfBirth
        {
            get { return _DayOfBirth; }
            set { _DayOfBirth = value; OnPropertyChanged("DayOfBirth"); }
        }

        private string _PhoneNumber;

        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; OnPropertyChanged("PhoneNumber"); }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; OnPropertyChanged("Email"); }
        }

        private Status _Status;

        public Status Status
        {
            get { return _Status; }
            set { _Status = value; OnPropertyChanged("Status"); }
        }
    }
}
