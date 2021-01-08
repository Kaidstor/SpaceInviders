using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Exit : MenuItem 
    {
        public new static char[,] message = { {'E', 'X', 'I', 'T'} };
        
        public Exit(MatrixPosition topLeft)
            : base(topLeft, message)
        {
        }
        public override void TakeAction(Engine engine)
        {
            Environment.Exit(0);
        }
    }
}
