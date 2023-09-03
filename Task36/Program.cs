/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


Console.Write("Введите кол-во элементов в массиве: ");
int[] arr = GetRandomArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Сумма элементов стоящих на чётных позициях равна: " + FindSumEvenNumbers(arr));
Console.WriteLine("Сумма элементов стоящих на нечётных позициях равна: " + FindSumUnevenNumbers(arr));

int FindSumEvenNumbers(int[] array)
{   
    int sumEvenNumber = 0; 

    for (int i = 1; i < array.Length; i += 2)
    {
        sumEvenNumber = sumEvenNumber + array[i];
    }
    return sumEvenNumber;       
}

int FindSumUnevenNumbers(int[] array)
{   
    int sumUnvenNumber = 0; 

    for (int i = 0; i < array.Length; i += 2)
    {
        sumUnvenNumber = sumUnvenNumber + array[i];
    }
    return sumUnvenNumber;       
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-15, 16);
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