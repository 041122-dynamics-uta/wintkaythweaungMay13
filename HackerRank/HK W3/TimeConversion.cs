using System;
using static System.Console;
using System.Collections.Generic;

class Solution
{
    static void Main(String[] args)
    {
        //No need to capture the size of array. I use array's length property instead.
        ReadLine();
        var ar_temp = ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, int.Parse);
        var result = MigratoryBirds(ar);
        WriteLine(result);
    }

    static int MigratoryBirds(int[] ar)
    {
        var birdTypeCounts = new int[5];

        for (int i = 0; i < ar.Length; i++)
            birdTypeCounts[ar[i] - 1]++;

        var maxBirdTypeCount = birdTypeCounts[0];
        var maxBirdType = 1;

        for (int i = 1; i < 5; i++)
        {
            if (birdTypeCounts[i] > maxBirdTypeCount)
            {
                maxBirdTypeCount = birdTypeCounts[i];
                maxBirdType = i + 1;
            }

            if (birdTypeCounts[i] == maxBirdTypeCount && i + 1 < maxBirdType)
                maxBirdType = i + 1;
        }using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {   
        //TryParse will return out with the correct time while converting 
        //the boolean will confirm if the time matches and conversion of string is true
        
        bool goodConversion = DateTime.TryParse(s, out DateTime time);
        
        if (goodConversion)
        {
            return time.ToString("HH:mm:ss");
        }
        return "Bad Input";
    }
   
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

        return maxBirdType;
    }
}