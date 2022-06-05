int[] a = {1, 11, 8, 4, 5};
int index = 0;
int max = 0;
int size = 5;
while(index < size)
{
    if(a[index] > max)
    {
        max = a[index];
    }
    index ++;
}

Console.Write("Max number is ");
Console.WriteLine(max);