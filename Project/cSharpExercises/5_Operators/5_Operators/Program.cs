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
           
            num++;// ''''''passed 
            return num;
           // throw new NotImplementedException($"Increment() is not implemented yet.");
        }

        /// <summary>
        /// This method takes an int and returns the int decremented once
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Decrement(int num)
        {
             num--;// ''''''passed 
            return num;
           //throw new NotImplementedException($"Decrement() is not implemented yet");
        }

        /// <summary>
        /// This method takes a boolean value and returns the opposite boolean value.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool Not(bool input)
        {
           input =! input;// ''''''passed 
           return input;
          //throw new NotImplementedException($"Not() is not implemented yet");
        }

        /// <summary>
        /// /// This method takes an int and returns the negative of that int.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Negate(int num)
        {
            //int num  =- num;
            //return num;

    
            throw new NotImplementedException($"Negate() is not implemented yet");

        }

        /// <summary>
        /// This method takes two ints and returns the sum
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Sum(int num1, int num2)
        {
            int total = num1 + num2 ;// ''''''passed 
            return total;
        // throw new NotImplementedException($"Sum() is not implemented yet");
        }

        /// <summary>
        /// This method takes two ints and returns the difference
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Diff(int num1, int num2)
        {
          int difference = num1 - num2 ;// ''''''passed 
          return difference;
           // throw new NotImplementedException($"Diff() is not implemented yet");
        }

        /// <summary>
        /// This method takes two ints and returns the product 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Product(int num1, int num2)
        { 
           // n1 =(int)num1 ;
            //n2 =(int)num2;
           //return (n1,n2);

          // int num1 = Console.ReadLine();
           // int num2 = Console.ReadLine();
        
           // int product = $"{num1}{num2}";
           // return product;
            
          throw new NotImplementedException($"Product() is not implemented yet");
        }

        /// <summary>
        /// This method takes two ints and returns the quotient
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Quotient(int num1, int num2)
        {
           int quotient = (num1 % num2); // ''''''passed 
           return quotient;
            //throw new NotImplementedException($"Quotient() is not implemented yet");
        }

        /// <summary>
        /// This method returns the remainder.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Remainder(int num1, int num2)
        {
            int remainder ,quotient =Math.DivRem ( num1,num2,out remainder);// ''''''passed 
            return remainder;
           // throw new NotImplementedException($"Remainder() is not implemented yet");
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
           if(num1 > num2 && num1 == num2)// ''''''passed 
            {
             return true;
            }
            else 
            {
                return false;
            }
            
            
           // throw new NotImplementedException($"And() is not implemented yet");
        }

        /// <summary>
        /// This method takes two ints and returns true if num1 is
        /// greater than num2 or if num1 is greater than zero. Otherwise, false.
        /// </summary>
        /// <param name="num1"></param>
        /// <returns></returns>
        public static bool Or(int num1, int num2)
        {
         if ( num1 >num2 || num1 > 0)
            {  
                 return true ;
            }
                                                       
            else 
            
                return false;
         
           
          // throw new NotImplementedException($"Or() is not implemented yet");
        }
    }
}
