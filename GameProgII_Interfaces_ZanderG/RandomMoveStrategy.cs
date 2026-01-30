using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Interfaces_ZanderG
{
    internal class RandomMoveStrategy : IMoveStrategy
    {
        Random _random = new Random();
        
        public Position Move(Position position)
        {
            int direction = _random.Next(1,5);
            int _xDirection = 0;
            int _yDirection = 0;

            if(direction == 1)
            {
                _xDirection = position._xPos + 1;

                if(_xDirection <= 30) position._xPos++;
            }
            else if(direction == 2)
            {
                _xDirection = position._xPos - 1;

                if(_xDirection >= 0) position._xPos--;
            }
            else if(direction == 3)
            {
                _yDirection = position._yPos + 1;

                if(_yDirection <= 0) position._yPos++;
            }
            else
            {
                _yDirection = position._yPos - 1;

                if(_yDirection >= 0) position._yPos--;
            }

            return position;
        }
    }
}
