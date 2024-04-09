using PosTest1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Julian
            SaveDataPlayer();
        }
        //Julian
        static void SaveDataPlayer()
        {
           Spieler player1 = new Spieler(); 

            player1.level = 1;
            player1.name = "Jan";
        }
    }
}
