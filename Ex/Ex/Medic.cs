using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    public class Medic : TeamMember
    {
        private int Xp { get; set; }
        public Medic(string Name, string Nationality , int Age , int Salary , int Xp)
        {
            this.Name = Name;
            this.Nationality = Nationality;
            this.Age = Age;
            this.Salary = Salary;
            this.Xp = Xp;
        }
    }
}
