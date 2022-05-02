using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _11_ArraysAndListsChallenge
{
    public class Program
    {

        public static void Main(string[] args)
        {
             //   int []x = 0;
               // int n =x .Length;
                //return SunIsShining;
        }//EoM

        /// <summary>
        /// This method takes an array of integers and returns a double, the average 
        /// value of all the integers in the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double AverageOfValues(int[] array)
        {
            List<int> ab =new List<int>{9,8,7,6,5,4,3,2};
            ab.Add ( 1,2,3,4,5,6,7 );
            ab.Add (5,1,0,2,8,9,3);
            ab.Add (9,2,6,5,8,2,33);
            
            

             // passed 
            double average = arr.Average();
            //var arr =new int[] {9,8,7,6,5} ;
            //double avg =Queryable.Average(arr.AsQueryable());
            
            return average;
        
         //double i  = Convert.ToInt32(array) ;
          //return i;
           
                     
         //  throw new NotImplementedException("AverageOfValues has not been implemented yet.");
        }

        /// <summary>
        /// This method increases each array element by 2 and 
        /// returns an array with the altered values.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] SunIsShining(int[] x)
        {  
           List <int> mylist =new List<int>();
           mylist.Add(1);
           mylist.Add(2);

                   return x;
          
         //int max =Enumerable.Range(0,x.GetLength(2)).Max(i => x [2,i]);
        // throw new NotImplementedException("SunIsShining has not been implemented yet.");
        }
    
        /// <summary>
        /// This method takes an ArrayList containing types of double, int, and string 
        /// and returns the average of the ints and doubles only, as a decimal.
        /// It ignores the string values and rounds the result to 3 decimal places toward the nearest even number.
        /// </summary>
        /// <param name="myArrayList"></param>
        /// <returns></returns>
        public static decimal ArrayListAvg(ArrayList myArrayList)
        {  
                double dbl = 0.1f;        
               // decimal dcml = (double) dbl;
                //   int a = 1;
             //decimal din =(int);
             // decimal result= Convert.ToDecimal(a );
              //decimal r2 =Convert.To
             // = Convert.ToDecimal(d);
             int i =(int)Math.Ceiling(dbl);
             return ( i);
             
             
             
             
          
          
       
    
       
       



            throw new NotImplementedException("ArrayListAvg has not been implemented yet.");
        }

        /// <summary>
        /// This method returns the rank (starting with 1st place) of a new 
        /// score entered into a list of randomly ordered scores.
        /// </summary>
        /// <param name="myArray1"></param>
        public static int ListAscendingOrder(List<int> scores, int yourScore)
        {
            throw new NotImplementedException("ListAscendingOrder has not been implemented yet.");
        }

        /// <summary>
        /// This method has with two parameters takes a List<string> and a string.
        /// The method returns true if the string parameter is found in the List, otherwise false.
        /// </summary>
        /// <param name="myArray2"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool FindStringInList(List<string> myArray2, string word)
        {
            throw new NotImplementedException("FindStringInList has not been implemented yet.");
        }
    }//EoP
}// EoN