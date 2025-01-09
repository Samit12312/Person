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
            Date johnBirthDate = new Date(1985, 5, 15);
            Passport johnPassport = new Passport("1001", "John", "Smith", johnBirthDate, "USA", "American", "married", "1234 Main St, City");
            johnPassport.AddKid("21442");
            // יצירת אובייקט Employee עם רק תעודת זהות
            Employee johnEmployee = new Employee(johnPassport, "john.smith@example.com", "123-456-7890", 50.0, 160.0);

            // הצגת פרטי העובד באמצעות ToString
            Console.WriteLine(johnEmployee.ToString());
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
    }
}
