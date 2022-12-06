// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

const int SIZE = 10;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;

int[] array = new int[SIZE];


int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void QuantityofPositiveNumbers(int[] arr, out int QuanP)
{
    QuanP = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            QuanP += 1;
        }
    }
}

array = FillArrayWithRandomNumbers(10, 100, 999);
Console.WriteLine('[' + string.Join(", ", array) + ']');
QuantityofPositiveNumbers(array, out int QuanP);
Console.WriteLine($"Quantity of even number is = {QuanP}");