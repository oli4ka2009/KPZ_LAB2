using LAB2.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Client> Clients { get; set; }
        [DataMember]
        public IEnumerable<Policy> Policies { get; set; }

        public DataModel()
        {
            Clients = new List<Client>();
            Policies = new List<Policy>();
        }

        public static string DataPath = "organizer.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);
            }
            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }
    }
}
