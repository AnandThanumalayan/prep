using System;
using System.Collections.Generic;

public class Program {
    public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		// Write your code here.
        // Is not a valid subsequence if the sequence is longer than the main array
        if(sequence.Count > array.Count)
        {
            return false;
        }
        
        for(int i=0; i < array.Count; i++){
            var presenceIndex = sequence.IndexOf(array[i]);
            if(presenceIndex >= 0){
                sequence.Remove(sequence[0]);
            }
        }
        return sequence.Count == 0;
	}
	public static bool IsValidSubsequence2(List<int> array, List<int> sequence) {
		// Write your code here.
        // Is not a valid subsequence if the sequence is longer than the main array
        if(sequence.Count > array.Count)
        {
            return false;
        }
        List<int> subSequence = new List<int>();
        //int previousIndex = 0;
        for(int i=0; i < array.Count; i++){
            var presenceIndex = sequence.IndexOf(array[i]);
            if(presenceIndex >= 0){
                sequence.Remove(sequence[0]);
            }
            // var presenceIndex = sequence.IndexOf(array[i]);
            // if(presenceIndex >= 0 && presenceIndex >= previousIndex){
            //     subSequence.Add(i);
            //     sequence.Remove(sequence[0]);
            //     previousIndex = presenceIndex;
            // }
        }
        // foreach item in sequence find index of the item in array
        return sequence.Count == 0;
	}
}

// true
//   "array": [1, 1, 1, 1, 1],
//   "sequence": [1, 1, 1]
// false
//   "array": [5, 1, 22, 25, 6, -1, 8, 10],
//   "sequence": [5, 1, 25, 22, 6, -1, 8, 10]
// false
//   "array": [1, 1, 6, 1],
//   "sequence": [1, 1, 1, 6]
// false
//   "array": [5, 1, 22, 25, 6, -1, 8, 10],
//   "sequence": [1, 6, -1, 5]
// true
//   "array": [1, 1, 2, 3, 4],
//   "sequence": [1, 2, 3]
// true
//   "array": [1, 1, 2, 3, 4],
//   "sequence": [1, 1, 3]
// false
//   "array": [1, 1, 2, 3, 4],
//   "sequence": [1, 1, 1]
// true
//   "array": [1, 1, 2, 3, 4],
//   "sequence": [1, 3]
// false
//   "array": [5, 1, 22, 25, 6, -1, 8, 10],
//   "sequence": [4, 5, 1, 22, 25, 6, -1, 8, 10]
// false
//   "array": [5, 1, 22, 25, 6, -1, 8, 10],
//   "sequence": [5, 1, 22, 22, 6, -1, 8, 10]
// false
//   "array": [5, 1, 22, 25, 6, -1, 8, 10],
//   "sequence": [5, 1, 22, 25, 6, -1, 8, 10, 10]