using static System.Console;
using static System.Convert;
using static System.Math;


int n; int[] arr2 = new int[105];
int[] arr3 = new int[105];

n  = ToInt32(ReadLine());
string str = ReadLine();
var arr1 = str.Split(" ");
for(int i = 0; i < n; i++)
{
    arr2[i] = ToInt32(arr1[i]);
}



for(int i = 1; i <= n; i++)
{
    arr3[i-1] = Array.IndexOf(arr2, i)+1;
}


for(int i = 0;i < n; i++)
{
    Write($"{arr3[i]} ");
}