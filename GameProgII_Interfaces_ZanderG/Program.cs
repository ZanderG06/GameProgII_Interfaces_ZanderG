using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Interfaces_ZanderG
{
    internal class Program
    {
        public static Player _player = new Player(playerPosition: new Position(2,3), playerColor: ConsoleColor.Cyan);
        public static Enemy _enemy = new Enemy(enemyPosition: new Position(10, 5), enemyColor: ConsoleColor.DarkRed);

        static void Main(string[] args)
        {
            IMoveStrategy _aggressiveMove = new AggressiveMoveStrategy(_player._playerPosition);
            IMoveStrategy _passiveMove = new PassiveMoveStrategy(_player._playerPosition);
            IMoveStrategy _randomMove = new RandomMoveStrategy();

            _enemy._moveStrategy = _passiveMove;

            while(true)
            {
                Console.Clear();
                Console.SetCursorPosition(_player._playerPosition._xPos, _player._playerPosition._yPos);
                Console.ForegroundColor = _player._playerColor;
                Console.Write("*");

                Console.SetCursorPosition(_enemy._enemyPosition._xPos, _enemy._enemyPosition._yPos);
                Console.ForegroundColor = _enemy._enemyColor;
                Console.Write("=");

                char playerInput = Console.ReadKey().KeyChar;

                if(playerInput == 'm')
                {
                    _enemy._enemyPosition = _enemy._moveStrategy.Move(_enemy._enemyPosition);
                }
                else if(playerInput == 'i')
                {
                    _enemy._moveStrategy = _aggressiveMove;
                }
                else if(playerInput == 'o')
                {
                    _enemy._moveStrategy = _passiveMove;
                }
                else if(playerInput == 'p')
                {
                    _enemy._moveStrategy = _randomMove;
                }
            }
        }
    }
}