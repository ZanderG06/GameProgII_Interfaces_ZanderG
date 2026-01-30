using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Interfaces_ZanderG
{
    internal class Program
    {
        public Player player = new Player(playerPosition: new Position(0,0), playerColor: ConsoleColor.Cyan);
        public Enemy enemy = new Enemy(enemyPosition: new Position(0, 5), enemyColor: ConsoleColor.DarkRed);

        static void Main(string[] args)
        {
            
        }
    }
}