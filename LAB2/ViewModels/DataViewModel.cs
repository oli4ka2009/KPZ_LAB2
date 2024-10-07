using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LAB2.Command;

namespace LAB2.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        private ObservableCollection<ClientViewModel> _clients { get; set; }

        public ObservableCollection<ClientViewModel> Clients
        {
            get { return _clients; }
            set { _clients = value; OnPropertyChanged("Clients"); }
        }

        private ObservableCollection<PolicyViewModel> _policies;

        public ObservableCollection<PolicyViewModel> Policies
        {
            get { return _policies; }
            set { _policies = value; OnPropertyChanged("Policies"); }
        }

        public ClientViewModel selectedClient;

        public PolicyViewModel selectedPolicy;

        private CustomCommand removeClientCmd;

        private CustomCommand removePolicyCmd;

        public CustomCommand RemoveClientCmd
        {
            get
            {
                return removeClientCmd ??
                  (removeClientCmd = new CustomCommand(
                  obj =>
                  {
                      ClientViewModel client = obj as ClientViewModel;
                      if (client != null)
                      {
                          Clients.Remove(client);
                      }
                  },
            (obj) => Clients.Count > 0));
            }
        }

        public CustomCommand RemovePolicyCmd
        {
            get
            {
                return removePolicyCmd ??
                       (removePolicyCmd = new CustomCommand(
                           obj =>
                           {
                               PolicyViewModel policy = obj as PolicyViewModel;
                               if (policy != null)
                               {
                                   Policies.Remove(policy);
                               }
                           },
                           (obj) => Policies.Count > 0));
            }
        }

        private CustomCommand addClientCmd;

        private CustomCommand addPolicyCmd;

        public CustomCommand AddClientCmd
        {
            get
            {
                return addClientCmd ??
                  (addClientCmd = new CustomCommand(
                  obj =>
                  {
                      ClientViewModel client = new ClientViewModel() { DayOfBirth = DateTime.Now};
                      if (client != null)
                      {
                          Clients.Add(client);
                      }
                      SelectedClient = client;
                  },
            (obj) => true));
            }
        }

        public CustomCommand AddPolicyCmd
        {
            get
            {
                return addPolicyCmd ??
                       (addPolicyCmd = new CustomCommand(
                           obj =>
                           {
                               PolicyViewModel policy = new PolicyViewModel() { StartDate = DateTime.Now, EndDate = DateTime.Now};
                               if (policy != null)
                               {
                                   Policies.Add(policy);
                               }
                               SelectedPolicy = policy;
                           },
                           (obj) => true));
            }
        }

        public ClientViewModel SelectedClient
        {
            get { return selectedClient; }
            set
            {
                selectedClient = value;
                OnPropertyChanged("SelectedClient");
            }
        }

        public PolicyViewModel SelectedPolicy
        {
            get { return selectedPolicy; }
            set
            {
                selectedPolicy = value;
                OnPropertyChanged("SelectedPolicy");
            }
        }

        public IEnumerable<Status> StatusValues
        {
            get
            {
                return Enum.GetValues(typeof(Status)).Cast<Status>();
            }
        }

        public IEnumerable<PolicyType> PolicyTypeValues
        {
            get
            {
                return Enum.GetValues(typeof(PolicyType)).Cast<PolicyType>();
            }
        }
    }
}
