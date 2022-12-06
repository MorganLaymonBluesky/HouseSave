using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorganMiaFinalExamProject
{
    internal class Address
    {
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address(int houseNumber, string streetName, string streetType, string city, string state, string zipCode)
        {
            HouseNumber = houseNumber;
            StreetName = streetName;
            StreetType = streetType;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public Address(Address addressObj)
        {
            HouseNumber = addressObj.HouseNumber;
            StreetName = addressObj.StreetName;
            StreetType = addressObj.StreetType;
            City = addressObj.City;
            State = addressObj.State;
            ZipCode = addressObj.ZipCode;
        }

        public override string ToString()
        {
            string address = "";
            address += $"{HouseNumber} {StreetName} {StreetType}, {City}, {State} {ZipCode}";
            return address;
        }
    }
}
