using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Interfaces_ZanderG
{
    internal class Player
    {
        public Position _playerPosition;
        public ConsoleColor _playerColor;

        public Player(Position playerPosition, ConsoleColor playerColor)
        {
            _playerPosition = playerPosition;
            _playerColor = playerColor;
        }
    }
}