using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Miguel","Chile",10,10,7,23,2000000,false);
            Player p2 = new Player("Juan","Colombia",8,10,6,21,2100000,true);
            Medic m = new Medic("Gabriela","Chile",29,3000000,100);
            Trainer t = new Trainer("Simon","Chile",18,2500000,20);
            Team t1 = new Team(t,m,"Miguels Team","Chile",true);
            Team t2 = new Team(t, m, "Chile Team", "Chile", false);
            p1.PlayerInjured += t.OnPlayerInjured;
            Console.WriteLine("Info jugadores,medico , entrenador en ese orden\n");
            p1.ShowInfo(); p2.ShowInfo();;m.ShowInfo(); t.ShowInfo();
            Console.WriteLine("\nProbando agregar jugador al equipo:\n");
            t1.Addplayer(p1);t1.Addplayer(p2);
            t2.Addplayer(p1);t2.Addplayer(p2);
            Console.WriteLine("\nMostrar info equipos\n");
            t1.ShowInfo();
            Console.WriteLine("\nequipo 2\n");
            t2.ShowInfo();
            Console.WriteLine("\nprobando evento lesion\n");
            p1.Injurie();
        }
    }
}
