IEnumerable<Wall> CreateWalls(IReadOnlyList<int> arr)
{
    List<Wall> walls = new ();

    var isWallExists = false;
    var wallStartIndex = 0;

    for (var i = 0; i < arr.Count; i++)
    {
        if (arr[i] == 0 && isWallExists is false) { }
        else if (arr[i] != 0 && isWallExists is false)
        {
            isWallExists = true;
            wallStartIndex = i;
        }
        else
        {

            if (i != arr.Count - 1 && arr[i] > arr[i + 1] && arr[i] >= arr[wallStartIndex])
            {
                walls.Add(new Wall {StartIndex = wallStartIndex, EndIndex = i});
                wallStartIndex = i;
            }
            else if (i == arr.Count - 1)
            {
                var j = i;
                for (; j > wallStartIndex; j--)
                {
                    if (arr[j] >= arr[i]) continue;
                    walls.Add(new Wall { StartIndex = wallStartIndex, EndIndex = i });
                    break;
                }
            }
        }
    }

    return walls;
}

int SumEmptySpace(IEnumerable<Wall> walls, IReadOnlyList<int> arr)
{
    var sum = 0;

    foreach (var wall in walls)
    {
        var firstWallHeights = arr[wall.StartIndex];
        var secondWallHeight = arr[wall.EndIndex];
        var minWallHeight = firstWallHeights > secondWallHeight ? secondWallHeight : firstWallHeights;

        for (var i = wall.StartIndex + 1; i <= wall.EndIndex-1; i++)
        {
            sum += minWallHeight - arr[i];
        }
    }

    return sum;
}

var arr = new[] {0, 7, 2, 9, 0, 4, 6, 7};

var walls = CreateWalls(arr);
var sum = SumEmptySpace(walls, arr);

Console.WriteLine($"Result is {sum}");

internal class Wall
{
    public int StartIndex { get; set; }

    public int EndIndex { get; set; }
}