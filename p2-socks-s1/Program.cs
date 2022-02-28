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
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        ar.Sort();
        var sortedList = ar;

        int previousItem = 0;
        int numberOfCurrentItem = 0;
        int totalPairs = 0;
        for(int i = 0; i < sortedList.Count(); i++){
            previousItem = i > 0 ? sortedList[i - 1] : sortedList[i - 0];
            if(sortedList[i] != sortedList[i - 1]){
                numberOfCurrentItem = (sortedList.LastIndexOf(sortedList[i]) + 1) - i;
                if(numberOfCurrentItem > 0){
                    totalPairs = totalPairs + (numberOfCurrentItem / 2);
                }
            }
        }
        return totalPairs;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        Console.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}
