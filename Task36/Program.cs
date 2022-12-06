// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

const int SIZE = 10;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 10;

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

void SummE(int[] arr, out int Sum)   // SummE is Sumofelementswithoddindeks
{
    Sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2!=0)
        {
            Sum += arr[i];
        }
    }
}

array = FillArrayWithRandomNumbers(10, 1, 10);
Console.WriteLine('[' + string.Join(", ", array) + ']');
SummE(array, out int Sum);
Console.WriteLine($"Summ of elements with odd indeks is = {Sum}");