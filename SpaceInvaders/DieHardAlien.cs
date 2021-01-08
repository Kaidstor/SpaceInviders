using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    public class DieHardAlien : AlienShip
    {
        public DieHardAlien(MatrixPosition topLeft, MatrixPosition speed)
            : base(topLeft, speed)
        {
            base.image = new char[,] { { '~' } };
            this.life = 3;
        }
    }
}
