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
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        int jumpCtr = 0;
        int ctr = 0;
        int maxIndex = c.Count() - 1;
        if(c[0] == 1){
            return 0;
        }
        while(ctr < maxIndex){
            if ((ctr + 2 <= maxIndex) && c[ctr + 2] == 0){
                ctr = ctr + 2;
            }
            else{
                ctr = ctr + 1;
            }
            jumpCtr++;
        }
        return jumpCtr;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);

        Console.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}
