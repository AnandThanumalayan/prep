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

class Solution {

    // Complete the maxSubsetSum function below.
    static int maxSubsetSum(int[] arr) {
        // [-2, 1, 3, -4, 5]
        int[] adjacentSums = new int[arr.Length];
        for(int i = 0; i < arr.Length - 2; i++){
            adjacentSums[i] = arr[i] + f(i, arr);
        }
        return adjacentSums.Max();
    }
    
    static int f(int i, int[] arr){
        if(i + 2 < arr.Length){
            return arr[i+2] + f(i + 2, arr);
        }
        return 0;
    }

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = maxSubsetSum(arr);

        Console.WriteLine(res);

        // textWriter.Flush();
        // textWriter.Close();
    }
}
