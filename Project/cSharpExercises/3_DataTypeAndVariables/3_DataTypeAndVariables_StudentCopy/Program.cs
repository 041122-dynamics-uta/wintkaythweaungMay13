using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        


            //
            //
            // Insert code here.
            //
            //
        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {     //byte
        //long,uint,string, ulong,int , float ,sbyte,short,decidmal ,char ,ushort,double,
       
      // string [] bytes= {obj}; 
       //long[]longs ={obj};
       //uint[]uints ={obj};
      // string[]strings ={obj};
      // ulong[]ulongs ={obj};
   //    int[]ints ={obj};
     //  float[]floats ={obj};
       //sbyte[]sbytes ={obj};
      // short[]shorts ={obj};
       //decimal[]decimals ={obj};
      // char[]chars ={obj};
      // ushort[]ushorts ={obj};
       //double[]doubles ={obj};
      // Console.ReadLine(x);

    //  v1 = Convert. (bytes,longs,uints,strings,ulongs, ints,floasts,sbytes,shorts,decimals,chars,ushorts,doubles);
        
      
      //  switch(x)
        //{
          //  case x == bytes:
          //   string obj = Encoding.UTF8(bytes);
           //  break;

            //  case x == longs:
            //  string obj = longs.ToString();
              //break;

              //case x == uints:
              //string obj = uints.ToString();
            //  break;




      //  }

           // new object[] = " ";

              //  Object obj {}
                   
          //  switch (obj.GetType())
            //{
              //  case (Convert.ToByte(obj)):
                 

                // return obj;
            
           // break;
            //}
            string str = "";
            switch (Type.GetTypeCode (obj.GetType()))
            {
              case byte byt : 
              return "Data type => byte";
              break;
             return "Data type => long";
              break;
              case uint uints : 
              return "Data type => uint";
              break;  
              case string str : 
              return "Data type => string";
              break;
              case ulong ulg : 
              return "Data type => ulong";
              break;
              case int ink : 
              return "Data type => int"; 
              break;
              case float fl : 
              return "Data type => float"; 
              break;
              sbytes,shorts,decimals,chars,ushorts,doubles
              case short  shrt : 
              return "Data type => short"; 
              break;
              case decimal dec : 
              return "Data type => decimal"; 
              break;
              case char cha : 
              return "Data type => char"; 
              break;case ushort ushrt : 
              return "Data type => ushort"; 
              break;
              case double dbl : 
              return "Data type => double"; 
              break;
              
            }
                   // throw new NotImplementedException($"PrintValues() has not been implemented");
            
        }    
        
        

        /// <summary>
        /// THis method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {      
            // int wit =  Convert.Int32.TryParse(numString);
           // return numString;
             //return (wit);
            throw new NotImplementedException($"StringToInt() has not been implemented");

         } 
     }
}
    
    // end of class
// End of Namespace
