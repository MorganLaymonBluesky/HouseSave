using MorganMiaFinalExamProject;

int houseNumber;
string streetName;
string streetType;
string city;
string state;
string zipCode;
decimal value;
string inCityCheck;
bool inCity;
int i = 0;
Property[] totalProperties = new Property[10];

NewProperty();
Console.WriteLine(DisplayProperties());

void NewProperty()
{
    Console.WriteLine("Please enter the property's house number: ");
    houseNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter the property's street name: ");
    streetName = Console.ReadLine();
    Console.WriteLine("Please enter the property's street type: ");
    streetType = Console.ReadLine();
    Console.WriteLine("Please enter the property's city: ");
    city = Console.ReadLine();
    Console.WriteLine("Please enter the property's state: ");
    state = Console.ReadLine();
    Console.WriteLine("Please enter the property's zipcode: ");
    zipCode = Console.ReadLine();
    Address address = new Address(houseNumber, streetName, streetType, city, state, zipCode);
    Console.WriteLine("Please enter the property's value: (Example: xxxxxx.xx)");
    value = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Is this property located within the city? (Input Yes or No.)");
    inCityCheck = Console.ReadLine().ToUpper();
    while (inCityCheck != "YES" && inCityCheck != "NO")
    {
        Console.WriteLine("Error: Invalid Input. Is this property located within the city? (Input Yes or No.)");
        inCityCheck = Console.ReadLine().ToUpper();
    }
    if (inCityCheck == "YES")
    {
        inCity = true;
    }
    else
    {
        inCity = false;
    }
    totalProperties[i++] = new Property(address, value, inCity);
}

string DisplayProperties()
{
    string allProperties = "\n";
    foreach(var item in totalProperties)
    {
        if (item != null)
        {
            allProperties += $"{item}\n";
        }
    }
    if (allProperties == "")
    {
        allProperties += "There are no properties added yet.\n";
    }
    return allProperties;
}

void RemoveProperty()
{

}