/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

Console.Write("Введите кол-во элементов в массиве: ");
int[] arr = GetRandomArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(arr);
Console.WriteLine();
Console.WriteLine(FindMaxNumber(arr));


int FindMaxNumber(int[] array)
{   
    int maxNumber = array[0];
    for (int i=0; i < array.Length; i++)
    {    
        if (array[i] > maxNumber)
            {
                array[i] = maxNumber;    
            }  
    }
    return maxNumber;        
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int iteam in arr)
    {
        Console.Write(iteam + " ");
    }
}