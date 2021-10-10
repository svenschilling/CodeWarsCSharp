﻿using System;

namespace CreatePhoneNumber
{
    class Program
    {
        /*
            Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

            Example
            Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
            The returned format must be correct in order to complete this challenge.
            Don't forget the space after the closing parentheses!
        */
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            CreatePhoneNumber(numbers);
        }
        static string CreatePhoneNumber(int[] numbers)
        {
            string number = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                number += numbers[i];
            }

            string phoneNumber = "(" + number.Substring(0,3) + ") " + number.Substring(3,3) + "-" + number.Substring(6,4);

            return phoneNumber;
        }
    }
}