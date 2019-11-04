using System;
using static System.Console;

namespace LoopyThings
{
    class Program
    {
        static void Main(string[] args)
        {

            int minutes = 0;  //Total number of Minutes
            string input; //user input
            bool run = true;

            while (run) //run until user puts in non-integer
            {
                input = ReadLine(); //gets user input

                //checks to see input can be converted to an integer and sets minutes to the user input
                run = Int32.TryParse(input, out minutes);

                if (run) //if user input is an integer do math
                {
                    int hours = minutes / 60; //Number of hours in the minutes
                    int rMinutes = minutes % 60; //Remainder minutes

                    WriteLine(minutes + " minutes is " +
                        hours + " hours and " + rMinutes + " minutes.");
                }
                else 
                {
                    WriteLine("exiting");
                }
            }

        }
    }
}
