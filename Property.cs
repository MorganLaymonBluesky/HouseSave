using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorganMiaFinalExamProject
{
    internal class Property
    {
        public Address Address { get; set; }
        public decimal Value { get; set; }
        public bool InCity { get; set; }

        public Property(Address address, decimal value, bool inCity)
        {
            Address = address;
            Value = value;
            InCity = inCity;
        }

        public Property(Property property)
        {
            Address = property.Address;
            Value = property.Value;
            InCity = property.InCity;
        }

        public decimal CalculateCountyTax()
        {
            decimal countyTax = 0m;
            countyTax = Math.Round(Value * 0.025m, 2);
            return countyTax;
        }
        public decimal CalculateCityTax()
        {
            decimal cityTax = 0m;
            if (InCity)
            {
                if (Value < 50000m)
                {
                    cityTax = Math.Round(Value * 0.01m, 2);
                }
                else if (Value >= 50000m && Value < 100000m)
                {
                    cityTax = Math.Round(Value * 0.02m, 2);
                }
                else if (Value >= 100000m)
                {
                    cityTax = Math.Round(Value * 0.03m, 2);
                }
            }
            return cityTax;
        }

        public decimal CalculatePropertyTax()
        {
            decimal totalTax = 0;
            totalTax = Math.Round(CalculateCityTax() + CalculateCountyTax(), 2);
            return totalTax;
        }

        public override string ToString()
        {
            string propertyInfo = "";
            propertyInfo += $"The Address is: {Address}\n";
            propertyInfo += $"The Value is: {Value}\n";
            propertyInfo += $"The County Taxes are: {CalculateCountyTax()}\n";
            propertyInfo += $"The City Taxes are: {CalculateCityTax()}\n";
            propertyInfo += $"The Total Taxes are: {CalculatePropertyTax()}\n";
            return propertyInfo;
        }
    }
}
