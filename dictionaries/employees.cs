using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries
{
    public class Employees
    {
        public int Rate { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public Employees(string name, int age, string role, int rate) { 
            this.Rate = rate;
            this.Age = age;
            this.Name = name;
            this.Role = role;
        }
        public int salaray
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
    }   
}

