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
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        //StringBuilder finalStringBuilder = new StringBuilder();

        var inputStringAs = s.Where(x => x == 'a').Count();
        var duplicationTimes = n/(s.Count());

        long substringLength = n % (s.Count());
        var substring = s.Substring(0,(int)substringLength);

        var substringAs = substring.Where(x => x == 'a').Count();

        var totalAs = (duplicationTimes * inputStringAs) + substringAs;
        
        // for(int i=0; i<duplicationTimes; i++){
        //     finalStringBuilder.Append(s);
        // }

        // finalStringBuilder.Append(substring);
        // var numberOfAs = finalStringBuilder.ToString().Where(x => x == 'a').Count();

        // return numberOfAs;

        return totalAs;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        Console.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}
