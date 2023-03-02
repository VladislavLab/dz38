// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double []GetArray(int size, double MinValue, double MaxValue)
{
    double[] ResAr=new double[size];
    for(int i=0; i<size;i++)
    {
        ResAr[i]=new Random().NextDouble()*(MaxValue - MinValue+1)+MinValue;
    }
    return ResAr;
}


double DiffMax(double [] array)
{
    double MaxRes=array[0];
    for (int i=0; i<array.Length;i++)
    {
        if(array[i]>MaxRes) 
        {
            MaxRes=array[i];
        }
    }
    return MaxRes;
}

double DiffMin(double [] array)
{
    double MinRes=array[0];
    for (int i=0; i<array.Length;i++)
    {
        if(array[i]<MinRes) 
        {
            MinRes=array[i];
        }
    }
    return MinRes;
}
Console.Clear();
double[] array=GetArray(5, 1,100);
Console.WriteLine(string.Join(", ", array));
double DiffMaxMin=DiffMax(array)-DiffMin(array);
Console.WriteLine($"Разницa между максимальным и минимальным элементов массива равна {DiffMaxMin}"!);