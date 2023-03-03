int CountSpaceCanBeFilled(int indexFirstWall, int indexSecondWall, int[] wallsArray)
{
    int sum = 0, lowestValueWall = indexFirstWall.CompareTo(indexSecondWall) >= 0 ? wallsArray[indexSecondWall] : wallsArray[indexFirstWall];

    for (int i = indexFirstWall + 1; i < indexSecondWall; i++)
    {
        sum += lowestValueWall - wallsArray[i];
    }

    return sum;
}

var arr = new int[] {0, 7, 2, 9, 0, 4, 6, 7};

int indexFirstHighestWall = 0, indexSecondHighestWall = 0, valueFirstHighestWall = arr[0], valueSecondHighestWall = -1, sum = 0;
bool searchingSecondWall = false;



Console.WriteLine($"Result is {sum}");