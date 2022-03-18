
var s = new string[] {"A"," ","m","a","n",","," ","a"," ","p","l","a","n",","," ","a"," ","c","a","n","a","l",":"," ","P","a","n","a","m","a"};
var charArray = s;
int counter = 0;

// recursion bootstrapping
reverseString(charArray, counter);

for(int i = 0; i < s.Length; i++){
    Console.WriteLine($"{i} : {s[i]} : {s.Length -1 - i}");
}

static void reverseString(string[] charArray, int currentCtr){
    int totalLength = charArray.Length - 1;
    int frontCtr = currentCtr;
    int backCtr = totalLength - currentCtr;

    // recursion end condition - stop when the counters reach the middle
    // of a even number sized or odd number sized array
    if(backCtr - frontCtr <= 0){
        return;
    }
    string swapChar;
    
    // swapping the characters
    swapChar = charArray[frontCtr];
    charArray[frontCtr] = charArray[backCtr];
    charArray[backCtr] = swapChar;

    currentCtr = currentCtr + 1;

    reverseString(charArray, currentCtr);
}

// var charArray = s.ToCharArray();
// int counter = 0;

// // recursion bootstrapping
// reverseString(charArray, counter);

// static void reverseString(char[] charArray, int currentCtr){
//     int totalLength = charArray.Length - 1;
//     int frontCtr = currentCtr;
//     int backCtr = totalLength - currentCtr;

//     // recursion end condition - stop when the counters reach the middle
//     // of a even number sized or odd number sized array
//     if(backCtr - frontCtr <= 1){
//         return;
//     }
//     char swapChar;
    
//     // swapping the characters
//     swapChar = charArray[frontCtr];
//     charArray[frontCtr] = charArray[backCtr];
//     charArray[backCtr] = swapChar;

//     currentCtr = currentCtr + 1;

//     reverseString(charArray, currentCtr);
// }