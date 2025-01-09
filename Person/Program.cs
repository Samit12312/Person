using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void Targil1()
        {
            Date johnBirthDate = new Date(1985, 5, 15);
            Passport johnPassport = new Passport("1001", "John", "Smith", johnBirthDate, "USA", "American", "married", "1234 Main St, City");
            johnPassport.AddKid("2001");
            johnPassport.AddKid("2002");

            Date janeBirthDate = new Date(1987, 8, 25);
            Passport janePassport = new Passport("1002", "Jane", "Doe", janeBirthDate, "USA", "American", "married", "5678 Second St, City");
            janePassport.AddKid("2001");

            Date mikeBirthDate = new Date(1983, 3, 5);
            Passport mikePassport = new Passport("1003", "Mike", "Johnson", mikeBirthDate, "USA", "American", "married", "7890 Third St, City");
            mikePassport.AddKid("2002");

            Date lisaBirthDate = new Date(1990, 11, 17);
            Passport lisaPassport = new Passport("1004", "Lisa", "White", lisaBirthDate, "Canada", "Canadian", "single", "4567 Fourth St, City");

            Date jackBirthDate = new Date(1982, 2, 3);
            Passport jackPassport = new Passport("1005", "Jack", "Black", jackBirthDate, "USA", "American", "married", "7890 Fifth St, City");
            jackPassport.AddKid("2003");


            Person[] people = new Person[5];
            people[0] = new Person(johnPassport, "john.smith@example.com", "123-456-7890");
            people[1] = new Person(janePassport, "jane.doe@example.com", "234-567-8901");
            people[2] = new Person(mikePassport, "mike.johnson@example.com", "345-678-9012");
            people[3] = new Person(lisaPassport, "lisa.white@example.com", "456-789-0123");
            people[4] = new Person(jackPassport, "jack.black@example.com", "567-890-1234");

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].GetPassport().GetFamilysituation() == "married")
                {
                    Console.WriteLine(people[i].GetPassport().GetName());
                }
            }
        }
        static void Targil2()
        {
            Employee[] employees = new Employee[3];
            double totalSalary = 0;
            double totalNationalInsurance = 0;
            double totalIncomeTax = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for Employee {i + 1}:");

                Console.Write("Enter passport ID: ");
                string id = Console.ReadLine();

                Console.Write("Enter first name: ");
                string name = Console.ReadLine();

                Console.Write("Enter last name: ");
                string lastname = Console.ReadLine();

                Console.Write("Enter birth year: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Enter birth month: ");
                int month = int.Parse(Console.ReadLine());

                Console.Write("Enter birth day: ");
                int day = int.Parse(Console.ReadLine());

                Console.Write("Enter country: ");
                string country = Console.ReadLine();

                Console.Write("Enter nation: ");
                string nation = Console.ReadLine();

                Console.Write("Enter family status: ");
                string familysituation = Console.ReadLine();

                Console.Write("Enter address: ");
                string address = Console.ReadLine();

                Date birthDate = new Date(year, month, day);
                Passport passport = new Passport(id, name, lastname, birthDate, country, nation, familysituation, address);

                Console.Write("Enter email: ");
                string email = Console.ReadLine();

                Console.Write("Enter phone number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Enter hourly income: ");
                double hourlyIncome = double.Parse(Console.ReadLine());

                Console.Write("Enter hours worked: ");
                double hoursWorked = double.Parse(Console.ReadLine());

                Employee employee = new Employee(passport, email, phoneNumber, hourlyIncome, hoursWorked);
                employees[i] = employee;

                totalSalary += employee.GetHourlyincome() * employee.GetHoursworked();
                totalNationalInsurance += (employee.GetHourlyincome() * employee.GetHoursworked()) * 0.031;
                totalIncomeTax += (employee.GetHourlyincome() * employee.GetHoursworked()) * 0.25;
            }

            Console.WriteLine("\nEmployee Details:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.WriteLine("\nSummary Report:");
            Console.WriteLine($"Total Salary Paid by Employer: {totalSalary}");
            Console.WriteLine($"Total National Insurance Contribution: {totalNationalInsurance}");
            Console.WriteLine($"Total Income Tax: {totalIncomeTax}");
        }
    }
    
}
