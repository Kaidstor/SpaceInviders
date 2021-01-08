using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class StartResume : MenuItem
    {
        public static char[,] message = { { 'S', 'T', 'A', 'R', 'T', '/', 'R', 'E', 'S', 'U', 'M', 'E', } };
        public StartResume(MatrixPosition topLeft)
            : base(topLeft, message)
        {
        }

        public override void TakeAction(Engine engine)
        {
            engine.Run();
        }

    }
}