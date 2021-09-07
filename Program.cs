﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Athletics_question
{
    class Program
    {
        static void Main(string[] args)
        {

            //Input name - Event - Squad number - Time taken for first 3 races - Calculate average - display summary of season so far

            string Name, Event;
            int SquadNO ,amountORaces;
            decimal Total, Average;
            
            
            Console.Write(" Enter your full name: ");
            Name = Console.ReadLine();

            Console.Write(" Enter your event: ");
            Event = Console.ReadLine();

            Console.Write(" Enter your squad number: ");
            // Read the below and try to understand while loops and catching exceptions
            // the below try and catch allows for someone to enter the wrong data type and still have the code run
            // Be wary of While loops, without a break in the logic somewhere they can run forever
            // CRTL + C cancels running code, handy when you accidentally never end a break with a loop
            while(true){
                try{
                    
                    SquadNO = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch(System.FormatException){
                    Console.WriteLine("Enter a valid number");
                }
            }

            Console.Write(" How many races you in? ");
            while(true){
                try{
                    amountORaces = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch(System.FormatException){
                    Console.WriteLine("Enter a valid number");
                }
            }
            Total = 0;
            // For loops took me forever to get, there is cleaner ways to write the below.
            for (var i = 0; i < amountORaces; i++) {
                decimal NewRace;
                Console.Write("What time did you get in Race Number " + (i + 1) + ": ") ;
                NewRace = Convert.ToDecimal(Console.ReadLine());
                
                Total = Total + NewRace;
            }
            

            Average = Total / amountORaces;

            Console.WriteLine(" Your average is: " + Average );

            Console.ReadKey();

        }
    }
}
