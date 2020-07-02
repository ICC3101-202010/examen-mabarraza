using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    public abstract class TeamMember : IShowInfo
    {
        protected int Age { get; set; }

        protected string Name { get; set; }

        protected string nationality;
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        protected int Salary { get; set; }

        public void ShowInfo()
        {
            Console.Write("Nombre:"+Name+". ");
            Console.Write("Edad:"+Age + ". ");
            Console.Write("Nacionalidad:"+Nationality + ". ");
            Console.WriteLine("Sueldo:"+Salary + ".");
        }
    }
}
