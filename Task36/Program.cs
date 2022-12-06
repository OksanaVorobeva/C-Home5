int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-10, 10);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
int sum = 0;
int Sum(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
       if(i%2==1)
       sum=sum+array[i];
    }
    return sum;
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine(Sum(array));
