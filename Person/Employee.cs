using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Employee
    {
        Passport passport;
        string email;
        string phonenumber;
        double hourlyincome;
        double hoursworked;
        public Employee(Passport passport, string email, string phonenumber, double hourlyincome, double hoursworked)
        {
            this.passport = passport;
            this.email = email;
            this.phonenumber = phonenumber;
            this.hourlyincome = hourlyincome;
            this.hoursworked = hoursworked;
        }
        public Employee(Passport passport)
        {
            this.passport = passport;
            this.email = "no email";
            this.phonenumber = "no phone number";
            this.hourlyincome = 0;
            this.hoursworked = 0;
        }
        public Passport GetPassport()
        {
            return this.passport;
        }
        public void SetPassport(Passport passport)
        {
            this.passport = passport;
        }
        public string GetEmail()
        {
            return this.email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetPhonenumber()
        {
            return this.phonenumber;
        }
        public void SetPhonenumber(string phonenumber)
        {
            this.phonenumber = phonenumber;
        }
        public double GetHourlyincome()
        {
            return this.hourlyincome;
        }
        public void SetHourlyincome(double hourlyincome)
        {
            this.hourlyincome = hourlyincome;
        }
        public double GetHoursworked()
        {
            return this.hoursworked;
        }
        public void SetHoursworked(double hoursworked)
        {
            this.hoursworked = hoursworked;
        }
        double NettoSallary()
        {
            double salary = this.hourlyincome * this.hoursworked;
            double incometax = salary * 0.25;
            double healthtax = salary * 0.031;
            double taxsomething = salary * 0.05;
            double netSalary = salary - incometax - healthtax - taxsomething;
            return netSalary;
        }
        public override string ToString()
        {
            return $"Employee Details:\nEmployee Name: {passport.GetName()} {passport.GetLastname()}\nEmployee Neto Salary: {NettoSallary()}";
        }

    }
}
