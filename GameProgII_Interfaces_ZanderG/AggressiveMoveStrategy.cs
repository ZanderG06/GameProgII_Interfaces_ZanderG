using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Interfaces_ZanderG
{
    internal class AggressiveMoveStrategy : IMoveStrategy
    {
        Position _playerPosition;

        public AggressiveMoveStrategy(Position playerPosition)
        {
            _playerPosition = playerPosition;
        }
        
        public Position Move(Position position)
        {
            int xFromPlayer = position._xPos - _playerPosition._xPos;
            int yFromPlayer = position._yPos - _playerPosition._yPos;

            if (position._xPos > _playerPosition._xPos && position._yPos > _playerPosition._xPos) 
            {
                if(xFromPlayer > yFromPlayer)
                {
                    if(position._xPos - 1 >= 0) position._xPos--;
                }
                else
                {
                    if(position._yPos - 1 >= 0) position._yPos--;
                }
            }
            else if(position._xPos > _playerPosition._xPos)
            {
                if(position._xPos - 1 >= 0) position._xPos--;
            }
            else if(position._yPos > _playerPosition._yPos)
            {
                if(position._xPos - 1 >= 0) position._yPos--;
            }
            else
            {
                if(xFromPlayer < yFromPlayer)
                {
                    if(position._xPos + 1 <= 30) position._xPos++;
                }
                else
                {
                    if(position._yPos + 1 <= 20) position._yPos++;
                }
            }

            return position;
        }
    }
}
