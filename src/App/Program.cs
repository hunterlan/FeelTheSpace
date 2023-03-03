var arr = new int[] {0, 7, 2, 9, 0, 4, 6, 7};

int indexFirstHighestWall = 0, indexSecondHighestWall = 0, valueFirstHighestWall = arr[0], valueSecondHighestWall = -1, sum = 0;

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > valueFirstHighestWall)
    {
        indexFirstHighestWall = i;
        valueFirstHighestWall = arr[i];
    }
}

Console.WriteLine($"Result is {sum}");