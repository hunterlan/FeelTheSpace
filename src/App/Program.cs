int CountSpaceCanBeFilled(int indexFirstWall, int indexSecondWall, int[] wallsArray)
{
    int sum = 0, lowestValueWall = indexFirstWall.CompareTo(indexSecondWall) >= 0 ? wallsArray[indexSecondWall] : wallsArray[indexFirstWall];

    for (int i = indexFirstWall + 1; i < indexSecondWall; i++)
    {
        sum += lowestValueWall - wallsArray[i];
    }

    return sum;
}

int[] GetMaxValueIndexes(int[] array)
{
    int maxValue = array.Max();
    List<int> indexes = new List<int>();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == maxValue)
        {
            indexes.Add(i);
        }
    }

    return indexes.ToArray();
}

var arr = new[] {0, 7, 2, 9, 0, 4, 6, 7};
int sum = 0;

/*int indexFirstHighestWall = 0, indexSecondHighestWall = 0, valueFirstHighestWall = arr[0], valueSecondHighestWall = -1;
bool searchingSecondWall = false;*/

var indexesMaxValue = GetMaxValueIndexes(arr);

if (indexesMaxValue.Length == 2 && indexesMaxValue.ElementAt(1) == 0 && indexesMaxValue.ElementAt(1) == arr.Length - 1)
{
    sum = CountSpaceCanBeFilled(0, arr.Length - 1, arr);
}
else if (indexesMaxValue.Length != arr.Length)
{
    
}

Console.WriteLine($"Result is {sum}");