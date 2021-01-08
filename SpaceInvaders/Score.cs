using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    public class Score : GameInformation
    {
        public Score(MatrixPosition topLeft, string msg)
            : base(topLeft, msg)
        {
        }
    }
}
