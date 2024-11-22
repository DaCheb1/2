using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Privet123
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public Person(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public int GetBirthYear()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - Age;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
