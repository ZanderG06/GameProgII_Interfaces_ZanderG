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
        public static Player _player = new Player(playerPosition: new Position(0,0), playerColor: ConsoleColor.Cyan);
        public static Enemy _enemy = new Enemy(enemyPosition: new Position(0, 5), enemyColor: ConsoleColor.DarkRed);

        static void Main(string[] args)
        {
            IMoveStrategy _aggressiveMove = new AggressiveMoveStrategy(_player._playerPosition);
            IMoveStrategy _passiveMove = new PassiveMoveStrategy(_player._playerPosition);
        }
    }
}