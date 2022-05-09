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
                maxBirdType = i + 1;using System.CodeDom.Compiler;
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
     * Complete the 'dayOfProgrammer' function below. 
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        string exactDate = year.ToString();
        
        if(year > 1918)// loop for years before transition
        {   //nested if statement
            if((year % 400) == 0 || ((year % 4) == 0 && (year % 100) != 0))
            {
                exactDate = exactDate.Insert(0, "12.09.");
            }
            else
            {
                exactDate = exactDate.Insert(0, "13.09.");
            }
        }
        else if(year == 1918)// loop for years after transition
        {
            exactDate = exactDate.Insert(0, "26.09.");
        }
        else
        {   //nested if statement
            if((year % 4) == 0)
            {
                exactDate = exactDate.Insert(0, "12.09.");
            }
            else
            {
                exactDate = exactDate.Insert(0, "13.09.");
            }
        }
        return exactDate;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
            }

            if (birdTypeCounts[i] == maxBirdTypeCount && i + 1 < maxBirdType)
                maxBirdType = i + 1;
        }

        return maxBirdType;
    }
}