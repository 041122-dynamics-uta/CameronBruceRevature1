using System.CodeDom.Compiler;
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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
//MY CODE GOES HERE
            arr.Sort();
            int mostFrequent = arr[0];
            int currentElement = arr[0];
            int topCount = 1;
            int currentCount = 0;
            //Count how man times <arrayelement> shows up in the array

            for(int i=0; i<arr.Count; i += currentCount)
            {
                
                
                    currentElement = arr[i];// (1, 1, 1, 3, 3, 3, 3, 5)
                    
                    currentCount = 0;
                    for(int x=0; x<arr.Count; x++)
                    {
                        if(currentElement == arr[x])
                        {
                            currentCount++; //current count plus 1
                        }
                        if(currentCount > topCount)
                        {
                            mostFrequent = currentElement;
                            topCount++;
                        }
                    }
                
            }
            return mostFrequent;
        }
    }// Input code ends
    
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

