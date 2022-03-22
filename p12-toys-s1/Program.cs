// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
     * Complete the 'maximumToys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY prices
     *  2. INTEGER k
     */

    public static int maximumToys(List<int> prices, int k)
    {
        for(int i = 0; i<prices.Count(); i++){
            int[] prefix = new int[1];
            prefix.Append(prices[i]);
            calculateCombinations(prefix, i, new List<int[]>(), prices);
        }
        return 0;
    }

    public static int calculateCombinations(int[] prefix, int startCtr, List<int[]> combinations, List<int> prices){
        for(int j = startCtr + 1; j < prices.Count(); j++){
            var combo = prefix;
            combo.Append(j);
            combinations.Add(combo);
            printCombo(combo);
            calculateCombinations(combo, j, combinations, prices);
        }
        return 0;
    }

    public static void printCombo(int[] combo){
        var comboStr = string.Join(",", combo);
        Console.WriteLine(comboStr);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> prices = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pricesTemp => Convert.ToInt32(pricesTemp)).ToList();

        int result = Result.maximumToys(prices, k);

        Console.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}
