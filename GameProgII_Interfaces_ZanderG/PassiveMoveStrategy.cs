using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Interfaces_ZanderG
{
    internal class PassiveMoveStrategy : IMoveStrategy
    {
        Position _playerPosition;

        public PassiveMoveStrategy(Position playerPosition)
        {
            _playerPosition = playerPosition;
        }
        
        public Position Move(Position position)
        {
            int _xFromPlayer = position._xPos - _playerPosition._xPos;
            int _yFromPlayer = position._yPos - _playerPosition._yPos;

            if(_xFromPlayer < _yFromPlayer && _xFromPlayer > 0 && _yFromPlayer > 0)
            {
                if(position._xPos + 1 <= 30) position._xPos++;
            }
            else if (_xFromPlayer > _yFromPlayer && _xFromPlayer > 0 && _yFromPlayer > 0)
            {
                if (position._yPos + 1 <= 20) position._yPos++;
            }
            else
            {
                if(_xFromPlayer < _yFromPlayer)
                {
                    if(position._yPos - 1 >= 0) position._yPos--;
                }
                else
                {
                    if(position._xPos - 1 >= 0) position._xPos--;
                }
            }
            
            return position;
        }
    }
}
