using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    public class Trainer : TeamMember
    {
        private int TP { get; set; }
        public Trainer(string Name , string Nationality , int Age , int Salary , int TP)
        {
            this.Name = Name;
            this.Nationality = Nationality;
            this.Age = Age;
            this.Salary = Salary;
            this.TP = TP;
        }
        public void OnPlayerInjured(object source , EventArgs e)
        {
            Console.WriteLine("Cambio arbitro jugador lesionado");
        }
    }
}
