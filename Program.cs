List<List<int>> input = new List<List<int>>()
{
    new List<int>(){ -1, -1, 0, -9, -2, -2 },
    new List<int>(){ -2, -1, -6, -8, -2, -5 },
    new List<int>(){ -1, -1, -1, -2, -3, -4 },
    new List<int>(){ -1, -9, -2, -4, -4, -5 },
    new List<int>(){ -7, -3, -3, -2, -9, -9 },
    new List<int>(){ -1, -3, -1, -2, -4, -5 }
};



static void hourglassSum(List<List<int>> arr)
{
    int overAllSum = int.MinValue;
    for (int i = 0; i <= arr.Count - 1; i++)
    {
        for (int j = 0; j <= arr[i].Count - 1; j++)
        {
            int sum = 0;
            if (j + 1 >= arr[i].Count || j + 2 >= arr[i].Count || i + 1 >= arr.Count || i + 2 >= arr.Count)
            {
                break;
            }
            sum += arr[i][j];
            sum += arr[i][j + 1];
            sum += arr[i][j + 2];
            sum += arr[i + 1][j + 1];
            sum += arr[i + 2][j];
            sum += arr[i + 2][j + 1];
            sum += arr[i + 2][j + 2];


            // overAllSum = sum > overAllSum ? sum : overAllSum;
            overAllSum = sum > overAllSum ? sum : overAllSum;



            Console.Write(sum);
            Console.Write(" ");
            // Console.WriteLine("");

            // Console.WriteLine($"{arr[i][j]} {arr[i][j + 1]} {arr[i][j + 2]} \n- {arr[i + 1][j + 1]} -  \n{arr[i][j]} {arr[i + 1][j + 1]} {arr[i + 2][j + 2]}");

            // Console.Write(arr[i][j]);
            // Console.Write(arr[i][j + 1]);
            // Console.Write(arr[i][j + 2]);
            // Console.WriteLine(" ");
            // Console.Write("-");
            // Console.Write(arr[i + 1][j + 1]);
            // Console.Write("- ");
            // Console.Write(" ");
            // Console.WriteLine(" ");
            // Console.Write(arr[i][j]);
            // Console.Write(arr[i + 1][j + 1]);
            // Console.Write(arr[i + 2][j + 2]);


            // else
            // {
            //     Console.Write("-");
            //     Console.Write(arr[i][j + 1]);
            //     Console.Write("- ");

            // }

        }
        Console.WriteLine("----------");

    }
    Console.WriteLine("overall sum: " + overAllSum);
}

hourglassSum(input);
