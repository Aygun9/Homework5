//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

const int SIZE = 5;
const int LEFT_RANGE = 10;
const int RIGHT_RANGE = 20;

double[] array = new double[SIZE];


double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void MinMax(double[] array, out double min, out double max)
{
    min = array[0];
    max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
}



array = FillArrayWithRandomNumbers(5, 10, 20);
Console.WriteLine('[' + string.Join(", ", array) + ']');
MinMax(array, out double min, out double max);
Console.WriteLine(max - min);