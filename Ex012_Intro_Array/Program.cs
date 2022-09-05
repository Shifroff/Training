// Find maximum from nine numbers
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//              0  1   2  9  4  5  6  7  8    element numbers
int[] array = {14,202,53,84,59,61,17,38,69};
 //array[0] = 15;                      show certain element of array
 //Console.WriteLine(array[5]);        write this element
int max = Max(
    Max (array[0],array[1],array[2]),
    Max (array[3],array[4],array[5]),
    Max (array[6],array[7],array[8]));
Console.Write("max=");
Console.WriteLine(max);

//int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3)); // In place of argument - function


//Console.Write("max=");
//Console.WriteLine(max);
