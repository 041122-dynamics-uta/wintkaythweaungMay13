//aka.ms/new-console-template for more information
 
using system;
namespace Calcualtor 
{   
        class program
     {
        static voice public static void Main(string[] args)
        {        
        Console.writeline (" Please enter function to be performend");
         Console.writeline (" Press 1 for Add ");
         Console.writeline (" Press 2 for Substract");
         Console.writeline (" Press 3 for Multiply");
         Console.writeline (" Press 4 for Divide");

         int totalnum = Convert.ToInt32(Console.readline ());
         Console.writeline ("Please enter first number");
         int num1 = Convert.ToInt32 (Console.readline());
         Console.writeline ("Please enter second number");
         int num2 = Conver .ToInt32 (Console.readline());
         int value = 0 ;

         switch (choice)
         
            {
             case 1: 
             
              {   value = Add (num1 , num2) ;
                 break;
              }    
              case 2:
              {
                  value = Substract (num1 ,num2 );
                  break;
              }
              case 3:
              {
                  value = Multiply (num1 ,num2 );
                  break;


              }
              case 4:
              {
                  value = Divide (num1 , num2 );

              }
              default 
                Console.writeline ("Warning !!!!!!!!!!System doesn't support your number!");
                COnsole.readline ();
            }

            Public static int Addition (int num1 , int num2 );
            {
                int value = num1 + num2 ;
                return value ;
            }
            
            Public static int Substraction (int num1 , int num2 );
            {
                int value = num1 - num2 ;
                return value ;
            }
            
            Public static int Multiplication (int num1 , int num2 );
            {
                int value = num1 * num2 ;
                return value ;
            }
            
            Public static int Division (int num1 , int num2 );
            {
                int value = num1 / num2 ;
                return value ;
            }






        }

    }        
}

