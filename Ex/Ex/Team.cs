using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    public class Team
    {
        public List<Player> TeamPlayers { get; set; }

        public TeamMember TeamTrainer { get; set; }

        public Medic TeamMedic { get; set; }

        public string Name { get; set; }

        public string Nationality { get; set; }

        public bool League { get; set; }

        public Team(Trainer TeamTrainer, Medic TeamMedic, string Name , string Nationality ,  bool League)
        {
            this.Name = Name;

            this.TeamTrainer = TeamTrainer;
            
            this.TeamMedic = TeamMedic;

            this.League = League;

            this.Nationality = Nationality;

            TeamPlayers = new List<Player>();
        }

        public void Addplayer(Player player) 
        {
            if(TeamPlayers.Count()==15)
            {
                Console.WriteLine("Limite de jugadores por equipo (15) alcanzado");
            }
            if (!League)//si el equipo no es de liga, checkeamos nacionalidad
            {
                if (player.Nationality.ToUpper() == Nationality.ToUpper())
                {
                    TeamPlayers.Add(player);
                    Console.WriteLine("Jugador añadido con exito.");
                }
                else
                    Console.WriteLine("Jugadores de distinta nacionalidad, no se puede añadir este jugador al equipo.");
            }
            else
            {
                TeamPlayers.Add(player);
                Console.WriteLine("Jugador añadido con exito.");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Nombre:" + Name + ". ");
            Console.WriteLine("Nacionalidad:" + Nationality + ". ");
            if (League)
                Console.WriteLine("Equipo de liga");
            else
                Console.WriteLine("Seleccion Nacional de "+Nationality);
            Console.WriteLine("Entrenador:");TeamTrainer.ShowInfo();
            Console.WriteLine("Medico:");TeamMedic.ShowInfo();
            Console.WriteLine("Jugadores:");
            foreach (Player p in TeamPlayers)
                p.ShowInfo();
        }
    }
}
