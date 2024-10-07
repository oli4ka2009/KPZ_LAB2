using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.ViewModels
{
    public class PolicyViewModel : ViewModelBase
    {
        private PolicyType _Type;

        public PolicyType Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }

        private DateTime _StartDate;

        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; OnPropertyChanged("StartDate"); }
        }

        private DateTime _EndDate;

        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; OnPropertyChanged("EndDate"); }
        }

        private decimal _PremiumAmount;

        public decimal PremiumAmount
        {
            get { return _PremiumAmount; }
            set { _PremiumAmount = value; OnPropertyChanged("PremiumAmount"); }
        }

        private decimal _CoverageAmount;

        public decimal CoverageAmount
        {
            get { return _CoverageAmount; }
            set { _CoverageAmount = value; OnPropertyChanged("CoverageAmount"); }
        }
    }
}
