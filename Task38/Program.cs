/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

Console.Write("Введите кол-во элементов в массиве: ");
double[] arr = GetRandomArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Максимальный элемент массива равен: " + "{0:0.000}", FindMaxNumber(arr));
Console.WriteLine("Минимальный элемент массива равен: " + "{0:0.000}", FindMinNumber(arr));
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна: " + "{0:0.000}", (FindMaxNumber(arr) - FindMinNumber(arr)));


double FindMaxNumber(double[] array)
{   
    double maxNumber = array[0];
    
    for (int i=0; i < array.Length; i++)
    {    
        if (array[i] > maxNumber)
            {
                maxNumber = array[i];     
            }  
    }
    return maxNumber;        
}

double FindMinNumber(double[] array)
{   
    double minNumber = array[0];

    for (int i=0; i < array.Length; i++)
    {    
        if (array[i] < minNumber)
            {
                minNumber = array[i];     
            }  
    }
    return minNumber;        
}

double[] GetRandomArray(int length)
{
    double[] result = new double[length];
    int maxValue = 166;
    int minValue = 1;

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue-minValue) + minValue;
    }
    return result;
}

void PrintArray(double[] arr)
{
    foreach (double iteam in arr)
    {
        Console.Write("{0:0.000}", iteam);
        Console.Write(" ");
    }
}








