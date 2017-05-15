using System;

namespace GettingStartedWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            DateTime birthDate;
            string addrLine1;
            string addrLine2;
            string city;
            string state;
            int zip;
            string country;

            firstName = "Denis";
            lastName = "Zolkin";
            birthDate = new DateTime(1991, 1, 28);
            addrLine1 = "Russia, Yaroslavl";
            addrLine2 = "";
            city = "Yaroslavl";
            state = "Yaroslavl oblast";
            zip = 123456;
            country = "Russia";

            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Address line 1: {addrLine1}");
            Console.WriteLine($"Address line 2: {addrLine2}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"State: {state}");
            Console.WriteLine($"Zip: {zip}");
            Console.WriteLine($"Country: {country}");
        }
    }
}
