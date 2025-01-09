using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        Passport passport;
        string email;
        string phoneNumber;
        public Person(Passport passport, string email, string phoneNumber)
        {
            this.passport = passport; this.email = email; this.phoneNumber = phoneNumber;
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

        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
