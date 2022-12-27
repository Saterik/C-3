int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}
int a1 = 1597;
int b1 = 414;
int c1 = 2342;
int a2 = 165876;
int b2 = 4111;
int c2 = 1225;
int a3 = 1455;
int b3 = 15805;
int c3 = 1509;

int max1 = Max(a1, b1, c1); //Результатом работы функции Max будет максимальное первой тройки игроков
int max2 = Max(a2, b2, c3);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);
