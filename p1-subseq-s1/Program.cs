using System;
using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		// Write your code here.
		int arrayLength = array.Count;
		int sequenceLength = sequence.Count;
		List<int> validSubSequence = new List<int>();

		for(int arrayCtr=0; arrayCtr < arrayLength; arrayCtr++)
		{
			for(int sequenceCtr=0; sequenceCtr < sequenceLength; sequenceCtr++)
			{
				int subSequenceCtr = arrayCtr + sequenceCtr;
				if(((arrayCtr + sequenceCtr) < array.Count) && (array[arrayCtr+sequenceCtr] == sequence[sequenceCtr]))
				{
					validSubSequence.Add(array[arrayCtr + sequenceCtr]);
				}
			}
			if(sequenceLength == validSubSequence.Count){
				return true;
			}
			validSubSequence = new List<int>();
		}
		return false;
	}
}
// a = [5,6,1,1,1,6,5,1,1,1,1]
// s1 = [1,6,5,1]
// s2 = [1,1,1]
// s3 = [1]
// s4 = [1,2,3]
// "array": [5, 1, 22, 25, 6, -1, 8, 10],
// "sequence": [1, 6, -1, -1]