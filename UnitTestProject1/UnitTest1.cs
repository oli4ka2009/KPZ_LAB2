using LAB2;
using LAB2.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var model = new DataModel();
            model.Policies = new List<Policy>() { new Policy() { Type=PolicyType.Business, StartDate=DateTime.Now, EndDate=DateTime.Now, CoverageAmount=100, PremiumAmount=1000} };
            model.Clients = new List<Client>() { new Client() { FirstName = "O", LastName = "H", DayOfBirth = DateTime.Now, Email = "efd", PhoneNumber = "23233", Status = Status.Active } };

            DataSerializer.SerializeData("organizer.dat", model);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var model = DataSerializer.DeserializeItem("organizer.dat");

            model.Policies = new List<Policy>() { new Policy() { Type = PolicyType.Business, StartDate = DateTime.Now, EndDate = DateTime.Now, CoverageAmount = 1000000, PremiumAmount = 1000 } };

            DataSerializer.SerializeData("organizer.dat", model);
        }
    }
}
