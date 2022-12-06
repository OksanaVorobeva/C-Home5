double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-100,100)/10.0D;
    return array;
}

void PrintArray(double[] array)
{
    foreach (double el in array)
        Console.Write($"{el}; ");
    Console.WriteLine();
}
double d = 0;
double max =0;
double Difference(double[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
          if (array[i] > max)
        {
            max = array[i];
        }

    }
        double min = max;
    for (int j = 0; j <array.Length; j++)
    {
        if (array[j] < min)
        {
            min = array[j];
        }
    }
    
    d = max - min;
    return d;
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine(Difference(array));
