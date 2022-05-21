using System;

namespace dotnetconsole_SweetnSalty
{
    class Program
    {
       public static void Main(string[] args)
      {
         Findmultiples (40);
         

      }
     static void Findmultiples (int n)
     { Console.WriteLine("Please enter your start number");
       int a=int .Parse(Console.ReadLine());
       Console.WriteLine ("Please enter your stop number");
       int b=int .Parse(Console.ReadLine());
       for (int i=1;i<=n;i++)
       {
         string s="";
         string result1=0;
         string result2=0;
         string result3=0;

         if(i==a)
         {
           a=a+3;
           s=s+"sweet";
           result1=s;
         }
         if (i==b)
         {
           b=b+5;
           s=s+"Salty";
           result2=s;
         }
         if(s=="sweet n salty")
         Console.WriteLine(i);
         
         
         else 
         {
           Console.WriteLine (s);
         }
        }
     }
     Console.WriteLine)
    }
}
