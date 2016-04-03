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

            DisplayWelcomeScreen();

            InitializeFinch(myFinch);

            DisplayGetFinchCommands(commands);

            //TerminateFinch(myFinch);

            DisplayClosingScreen();
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

        /// <summary>
        /// Display a welcome screen including the purpose of the application
        /// </summary>
        private static void DisplayWelcomeScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Welcome to the Command Array Application");
            Console.WriteLine("Author: John E Velis");
            Console.WriteLine();
            Console.WriteLine("You will be prompted to enter a series of commands for the Finch robot.");
            Console.WriteLine("The Finch robot will then execute each of the commands in the order they were entered.");

            DisplayContinuePrompt();
        }

        /// <summary>
        /// Display a closing screen
        /// </summary>
        private static void DisplayClosingScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Thank you for using the Command Array Application");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// Initialize the Finch robot
        /// </summary>
        private static void InitializeFinch(Finch myFinch)
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Attempting to connect to the Finch robot.");
            Console.WriteLine();

            myFinch.connect();

            for (int increment = 0; increment < 255; increment += 10)
            {
                myFinch.setLED(0, increment, 0);
                //myFinch.noteOn(increment * 100);
                myFinch.wait(200);
            }

            myFinch.setLED(0, 0, 0);
            myFinch.noteOff();

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("The Finch robot is now connected.");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// Shut down the Finch robot
        /// </summary>
        /// <param name="myFinch"></param>
        private static void TerminateFinch(Finch myFinch)
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Attempting to disconnect from the Finch robot.");
            Console.WriteLine();

            for (int increment = 255; increment > 0; increment -= 10)
            {
                myFinch.setLED(0, increment, 0);
                //myFinch.noteOn(increment * 100);
                myFinch.wait(200);
            }

            myFinch.setLED(0, 0, 0);
            myFinch.noteOff();

            myFinch.disConnect();

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("The Finch robot is now disconnected.");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        private static void DisplayGetFinchCommands(FinchCommand[] commands)
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Enter Command Sequence");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("You will be prompted for each command.");

            Console.WriteLine("Command Options: ");
            Console.Write("| ");
            foreach (var command in Enum.GetValues(typeof(FinchCommand)))
            {
                Console.Write(command + " | ");
            }
            Console.WriteLine();

            DisplayContinuePrompt();
        }
    }
}
