using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;



 // See https://aka.ms/new-console-template for more information

namespace Calculatorapp
{
    
class Calcuation 
    {
        static void Mian (String[]arges)
        {   
        Console.WriteLine("Please enter the fuction to be performed ");
        Console.WriteLine("Press 1 for Addition ");
        Console.WriteLine("Press 2 the Substraction ");
        Console.WriteLine("Press enter the Multiplicaiton ");
        Console.WriteLine("Press enter the Division ");
        Console.WriteLine("Press enter the Exit ");

        int choice = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine (" Please enter your first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter your second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int totalresult = 0 ;

          switch (choice)
            {
            case 1 :
                {
                choice = Addition (num1 ,num2);
                break;
                }
            case 2 :
            
             {
                 choice = Substrcon (num1, num2);
                 break;
             }
             case 3: 
             {
                 choice = Multipllicaiton (num1 ,num2);
                 break;

             }
             case 4 : 
             {
                choice = Division (num1 , num2);
                break;

             }
             case 5: 
             {
                choice = exit ;
                Console.WriteLine(" you choose you exit")
                break;

                
             }
             default:
             {             
                Console .WriteLine( "wrong! try again ");
                 break;
             }
             Console.WriteLine("The result is {0}",totalresult );
             Console.ReadKey ();


        }

        }
    public static int Addition (int num1 , int num2)
    {
     int totalresult = num1+num2;
     return totalresult;
    } 
    public static int Substraction (int num1 ,int num2)
    {
        int totalresult =num1-num2;
        return totalresult;
    }
    public static int Multiplicaiton(int num1, int num2)
    {
        int totalresult = num1*num2;
        return totalresult;
    }
        public static int Division (int num1 , int num2)
    {
        int totalresult = num1/num2;
        return totalresult;
    }
        }
    }






    
