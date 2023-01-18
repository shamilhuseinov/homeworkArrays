//1
int[,] arr = new int[3, 3]
{
    { 3,4,6},
    { 2,0,7},
    {3, 5, 7 }
};
int sum = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i == 2 - j)
        {
            sum += arr[i, j];
        }
    }
}
Console.WriteLine(sum);

//2
//int[,] arr = new int[3, 3]
//{
//    { 3,4,5},
//    { 2,0,7},
//    {3, 5, 7 }
//};

//int[,] arr2 = new int[3, 3]
//{
//    { 4,2,7},
//    { 1,9,5},
//    {5, 6, 3 }
//};

//int[,] arr3 = new int[3, 3]
//{
//    { 0,0,0},
//    { 0,0,0},
//    {0, 0, 0 }
//};
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        arr3[i, j] = arr[i, j] + arr2[i, j];
//        Console.Write(arr3[i, j] + " ");
//    }
//    Console.WriteLine();
//}


//3 sol diaqonal
//int[,] arr = new int[5, 5]
//{
//    { 3,4,5,8,1},
//    { 2,9,7,7,2},
//    {3, 5, 7 ,0,4},
//    {4, 5, 4, 3,2 },
//    {3,2,6,3,7 }
//};
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        if (i > 4 - j)
//        {
//            arr[i, j] = 0;
//        }
//        Console.Write(arr[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//11 sag diaqonal
//int[,] arr = new int[5, 5]
//{
//    { 3,4,5,8,1},
//    { 2,9,7,7,2},
//    {3, 5, 7 ,0,4},
//    {4, 5, 4, 3,2 },
//    {3,2,6,3,7 }
//};
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        if (i > j)
//        {
//            arr[i, j] = 0;
//        }
//        Console.Write(arr[i, j] + " ");
//    }
//    Console.WriteLine();
//}