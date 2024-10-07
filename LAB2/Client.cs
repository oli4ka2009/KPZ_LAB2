using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public DateTime DayOfBirth { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public Status Status { get; set; }
    }

    [DataContract]
    public enum Status
    {
        [EnumMember]
        Active,
        [EnumMember]
        Inactive
    }
}