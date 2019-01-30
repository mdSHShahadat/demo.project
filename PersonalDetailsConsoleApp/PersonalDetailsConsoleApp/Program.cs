using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetailsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName, middleName, lastName,
                   streetName, apartmentNo, villageName, postOfficeName, thanaName, cityName, zipCode,
                   phoneNo, email,
                   birthYear, birthMonth, birthDay, age;

            Console.WriteLine("Give Your Personal Information Here: ");
            Console.WriteLine("");
            Console.WriteLine(":::YOUR NAME:::");
            Console.WriteLine("");
            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter Middle Name: ");
            middleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine(":::ADDRESS:::");
            Console.WriteLine("");
            Console.Write("Enter Street Name: ");
            streetName = Console.ReadLine();
            Console.Write("Enter Apartment Name/No: ");
            apartmentNo = Console.ReadLine();
            Console.Write("Enter Village Name: ");
            villageName = Console.ReadLine();
            Console.Write("Enter Post office Name: ");
            postOfficeName = Console.ReadLine();
            Console.Write("Enter Thana Name: ");
            thanaName = Console.ReadLine();
            Console.Write("Enter City Name: ");
            cityName = Console.ReadLine();
            Console.Write("Enter Zip code: ");
            zipCode = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine(":::CONTACT INFORMATION:::");
            Console.WriteLine("");
            Console.Write("Enter Phone Number: ");
            phoneNo = Console.ReadLine();
            Console.Write("Enter your valid email address: ");
            email = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine(":::AGE:::");
            Console.WriteLine("");
            Console.Write("Enter Birth Year: ");
            birthYear = Console.ReadLine();
            Console.Write("Enter Birth Month: ");
            birthMonth = Console.ReadLine();
            Console.Write("Enter Birth Day: ");
            birthDay = Console.ReadLine();
            Console.Write("Enter Your Current Age: ");
            age = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Done!!! You have successfully given your personal information.");
            Console.WriteLine("");
            Console.WriteLine("-:Name:- ");
            Console.WriteLine(firstName + " " + middleName + " " + lastName);
            Console.WriteLine("-:Address:- ");
            Console.WriteLine("Street     : " + streetName);
            Console.WriteLine("Apartment  : " + apartmentNo);
            Console.WriteLine("Village    : " + villageName);
            Console.WriteLine("Post Office: " + postOfficeName);
            Console.WriteLine("Thana      : " + thanaName);
            Console.WriteLine("City       : " + cityName);
            Console.WriteLine("Zip Code   : " + zipCode);
            Console.WriteLine("-:Contact:- ");
            Console.WriteLine("Phone      : " + phoneNo);
            Console.WriteLine("Email      : " + email);
            Console.WriteLine("-:Date of Birth:- ");
            Console.WriteLine(birthDay + " " + birthMonth + " " + birthYear);
            Console.WriteLine("Current age: " + age);
            Console.WriteLine();
            Console.WriteLine(":::::::::::::::::::::::::::SEIP_ID:228540::::::::::::::::::::::::::::::");
            Console.ReadLine();
        }
    }
}
