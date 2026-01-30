using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Interfaces_ZanderG
{
    internal class Enemy
    {
        public Position _enemyPosition;
        public ConsoleColor _enemyColor;

        public Enemy(Position enemyPosition, ConsoleColor enemyColor)
        {
            _enemyPosition = enemyPosition;
            _enemyColor = enemyColor;
        }

        public IMoveStrategy _moveStrategy;
    }
}