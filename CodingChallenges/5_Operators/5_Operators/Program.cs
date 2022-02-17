﻿using System;

namespace _5_OperatorsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        /// <summary>
        /// This method takes an in and returns the int incremented once
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Increment(int num)
        {
            return ++num;
        }

        /// <summary>
        /// This method takes an int and returns the int decremented once
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Decrement(int num)
        {
            return --num;
        }

        /// <summary>
        /// This method takes a boolean value and returns the opposite boolean value.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool Not(bool input)
        {
            return !input;
        }

        /// <summary>
        /// /// This method takes an int and returns the negative of that int.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Negate(int num)
        {
            num *= -1;
            return num;

        }

        /// <summary>
        /// This method takes two ints and returns the sum
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// This method takes two ints and returns the difference
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Diff(int num1, int num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// This method takes two ints and returns the product 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Product(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// This method takes two ints and returns the quotient
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Quotient(int num1, int num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// This method returns the remainder.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Remainder(int num1, int num2)
        {
            return num1 % num2;
        }

        /// <summary>
        /// This method takes two ints and returns true if the first value is greater
        /// or equal to the second value, otherwise false.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="!"></param>
        /// <returns></returns>
        public static bool And(int num1, int num2)
        {
            if(num1 >= num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method takes two ints and returns true if num1 is
        /// greater than num2 or if num1 is greater than zero. Otherwise, false.
        /// </summary>
        /// <param name="num1"></param>
        /// <returns></returns>
        public static bool Or(int num1, int num2)
        {
            if (num1 > num2 && num1 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
