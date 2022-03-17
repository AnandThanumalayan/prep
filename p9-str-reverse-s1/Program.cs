// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var str = "hello world";
var charArray = str.ToCharArray();

// recursion bootstrapping
printReverse(charArray, charArray.Length - 1);

static void printReverse(char[] charArray, int remainingLength){
// recursion end condition
if(remainingLength < 0){
    return;
}
Console.Write(charArray[remainingLength]);
remainingLength = remainingLength - 1;

// recursion initiation
printReverse(charArray, remainingLength);
}