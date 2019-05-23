﻿using System;

namespace VALID_NUMBER_PURITY
{
    /*
     * Write a program and ask the user to enter a number. The number should be between 1 to 10.
     * If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
     * (This logic is used a lot in applications where values entered into input boxes need to be validated.)
     */

    public class ValidNumber

    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER: ");
            int number = int.Parse(Console.ReadLine());


            if (number > 0 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}