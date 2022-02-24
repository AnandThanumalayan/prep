using System;
using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		// Write your code here.
		int sequenceLength = sequence.Count;
		List<int> subsequence = new List<int>(sequenceLength);
		foreach(int s in sequence){
            if(array.Contains(s) && !subsequence.Contains(s)){
                subsequence.Add(s);
            }
		}
  	bool isSubSequence = subsequence.Count == sequence.Count;
		return isSubSequence;
	}
}