using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingActivity_CommandArray
{
    class Program
    {
        #region GLOBALS
        private enum FinchCommand
        {
            MOVEFORWARD,
            MOVEBACKWARD,
            STOP,
            DELAY,
            TURNRIGHT,
            TURNLEFT,
            LEDON,
            LEDOFF,
            TERMINATE
        }

        private const int NUMBER_OF_COMMNANDS = 5;
        private const int COMMAND_DURATION = 5;

        #endregion

        static void Main(string[] args)
        {
           FinchCommand[] commands = new FinchCommand[NUMBER_OF_COMMNANDS];
        }
    }
}
