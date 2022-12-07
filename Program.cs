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
bool propertyLimit = false;
bool exitProgram = false;
Property[] totalProperties = new Property[10];

Console.WriteLine("Welcome to the shittiest property manager you've ever used in your life! :D");
while (exitProgram != true)
{
    Console.WriteLine("\n        Property Manager        \n" +
        "--------------------------------\n" +
        "[1] - Create a New Property\n" +
        "[2] - Display All Properties\n" +
        "[3] - Remove Property\n" +
        "[4] - Exit\n");
    int selection = Convert.ToInt32(Console.ReadLine());
    switch (selection)
    {
        case 1:
            {
                NewProperty();
                break;
            }
        case 2:
            {
                Console.Clear();
                Console.WriteLine(DisplayProperties());
                break;
            }
        case 3:
            {
                Console.Clear();
                RemoveProperty();
                break;
            }
        case 4:
            {
                exitProgram = true;
                break;
            }
        default:
            {
                Console.WriteLine("Thanks for using the program. You broke me :)");
                break;
            }
    }
}

void NewProperty()
{
    if (propertyLimit == false)
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
        if (i == 10)
        {
            Console.WriteLine("Maximum property limit reached.");
            propertyLimit = true;
        }
    }
    else
    {
        Console.WriteLine("Error: Out of memory. Delete properties to make memory.");
    }
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
    int memoryNum = 0;
    Console.WriteLine("Please enter the memory number you would like to remove: ");
    memoryNum = Convert.ToInt32(Console.ReadLine());
    if (memoryNum <= totalProperties.Length)
    {
        if (totalProperties[memoryNum] != null)
        {
            totalProperties[memoryNum] = null;
        }
        else
        {
            Console.WriteLine("Error: Property location does not exist.");
        }
    }
    else
    {
        Console.WriteLine("Error: Property location does not exist.");
    }
}