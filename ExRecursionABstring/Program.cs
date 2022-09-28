string NumbersFor(int a,int b)
{
    string result = string.Empty;
    for (int i = a; i <= b;i++)

    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRecursion(int a, int b)
{
    if (a<=b) return $"{a} "+ NumbersRecursion(a+1,b);
    else return string.Empty;
}
Console.WriteLine(NumbersFor(1,10));
Console.WriteLine(NumbersRecursion(1,10));
