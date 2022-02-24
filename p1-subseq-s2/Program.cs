using System;
using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		// find the first occurence of sequence[0] in the array
		var firstOccurenceInArray = array.IndexOf(sequence[0]);

		// if the first item itself is not found, return
		if(firstOccurenceInArray < 0){
			return false;
		}

		// int maxLengthToCheck = firstOccurenceInArray + sequence.Count;
		// // iterate through the sequence list starting at the first occurence
		// for(int i=firstOccurenceInArray; i < maxLengthToCheck; i++){
		// 	if(array[i] == sequence[0]){
		// 		// increment the starting counter i ??
		// 	}
		// 	if(sequence[i] != array[i]){
		// 		return false;
		// 	}
		// }

		int i = 0;
		i = firstOccurenceInArray;
		int maxLengthToCheck = i + sequence.Count;
		while(i < maxLengthToCheck){
			if(array[i] == sequence[0]){
				// increment the max length
				maxLengthToCheck++;
			}
			if(sequence[i] != array[i]){
				return false;
			}
			i++;
		}
		return false;
	}
}

// a = [5,6,1,1,1,6,5,1,1,1,1]
// s1 = [1,6,5,1]
// s2 = [1,1,1]
// s3 = [1]
// s4 = [1,2,3]