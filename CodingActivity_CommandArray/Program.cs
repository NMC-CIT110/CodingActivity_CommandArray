using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinchAPI;

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
            LEDOFF
        }

        private const int NUMBER_OF_COMMNANDS = 5;
        private const int COMMAND_DURATION = 5;

        #endregion

        static void Main(string[] args)
        {
            FinchCommand[] commands = new FinchCommand[NUMBER_OF_COMMNANDS];
            Finch myFinch = new Finch();


            
        }

        /// <summary>
        /// Turn the cursor off and display a continue prompt to the user
        /// </summary>
        private static void DisplayContinuePrompt()
        {
            Console.WriteLine();

            //
            // turn cursor off
            //
            Console.CursorVisible = false;

            Console.Write("Press any key to continue.");
            Console.ReadKey();

            //
            // turn cursor on
            //
            Console.CursorVisible = true;
        }


    }
}
