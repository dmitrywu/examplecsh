int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// int a1 = 1454545, b1 = 21, c1 = 39;
// int a2 = 12, b2 = 2311, c2 = 33;
// int a3 = 13, b3 = 234124, c3 = 313;

int[] array = { 35, 223, 341, 435, 521, 64, 723, 83, 912 };

int finalResult = Max(
    Max (array[0],array[1],array[2]),
    Max (array[3],array[4],array[5]),
    Max (array[6],array[7],array[8]));

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int finalResult = Max(max1, max2, max3);

//int finalResult = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.Write(finalResult);