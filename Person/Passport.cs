using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Passport
    {
        string id;
        string name;
        string lastname;
        Date date;
        string country;
        string nation;
        string familysituation;
        string adress;
        string[] ids;
        int kids;

        public Passport(string id, string name, string lastname, Date date, string country, string nation, string familysituation, string adress)
        {
            this.id = id; this.name = name; this.lastname = lastname; this.date = date; this.country = country; this.nation = nation; this.familysituation = familysituation; this.adress = adress;
            this.ids = new string[3];
        }
        public void AddKid(string kidid)
        {
            if (kids < 3) 
            {
                this.ids[kids] = kidid; 
                kids++; 
            }
        }
        public void RemoveKid(string kidid)
        {
            for (int i = 0; i < kids; i++)
            {
                if (this.ids[i] == kidid)
                {
                    kids -= 1;
                    ids[i] = null;
                }
            }
        }
        public override string ToString()
        {
            return $"Passport ID: {id}, Name: {name} {lastname}, Date of Birth: {date}, Country: {country}, Nation: {nation}, " +
           $"Family Status: {familysituation}, Address: {adress}, Kids IDs: {string.Join(", ", ids.Take(kids))}";
        }
        public string GetId()
        {
            return this.id;
        }
        public void SetId(string id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetLastname()
        {
            return this.lastname;
        }
        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public Date GetDate()
        {
            return this.date;
        }
        public void SetDate(Date date)
        {
            this.date = date;
        }

        public string GetCountry()
        {
            return this.country;
        }
        public void SetCountry(string country)
        {
            this.country = country;
        }

        public string GetNation()
        {
            return this.nation;
        }
        public void SetNation(string nation)
        {
            this.nation = nation;
        }

        public string GetFamilysituation()
        {
            return this.familysituation;
        }
        public void SetFamilysituation(string familysituation)
        {
            this.familysituation = familysituation;
        }

        public string GetAdress()
        {
            return this.adress;
        }
        public void SetAdress(string adress)
        {
            this.adress = adress;
        }

        public string[] GetIds()
        {
            return this.ids;
        }
        public void SetIds(string[] ids)
        {
            this.ids = ids;
        }

        public int GetKids()
        {
            return this.kids;
        }
        public void SetKids(int kids)
        {
            this.kids = kids;
        }
    }
}
