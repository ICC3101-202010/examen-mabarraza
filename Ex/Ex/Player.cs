using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    public class Player : TeamMember , IShowInfo
    {
        private int AP { get; set; }

        private int DP { get; set; }

        private int Number { get; set; }

        private bool Goalie { get; set; }

        public delegate void InjuriesEventHandler(object source, EventArgs args);

        public event InjuriesEventHandler PlayerInjured;
        public Player(string Name, string Nationality, int AP, int DP,  int Number, int Age, int Salary, bool Goalie)
        {
            this.Name = Name;
            this.Nationality = Nationality;
            this.AP = AP;
            this.DP = DP;
            this.Number = Number;
            this.Age = Age;
            this.Salary = Salary;
            this.Goalie = Goalie;
        }

        public void Injurie()
        {
            Console.WriteLine("Profe me lesione!!!");
            OnPlayerInjured();
        }
        protected virtual void OnPlayerInjured()
        {
            if(PlayerInjured != null)
            {
                PlayerInjured(this, EventArgs.Empty);
            }
        }

    }
}
