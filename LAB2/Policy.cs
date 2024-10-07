using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    [DataContract]
    public class Policy
    {
        [DataMember]
        public PolicyType Type { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }

        [DataMember]
        public decimal PremiumAmount { get; set; }
        [DataMember]
        public decimal CoverageAmount { get; set; }
    }

    [DataContract]
    public enum PolicyType
    {
        [EnumMember]
        Auto,
        [EnumMember]
        Home,
        [EnumMember]
        Health,
        [EnumMember]
        Life,
        [EnumMember]
        Travel,
        [EnumMember]
        Business
    }
}
