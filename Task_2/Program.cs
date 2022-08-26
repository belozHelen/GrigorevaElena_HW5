// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях. 
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = new int[10];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);
CalculateSum(numbers);

void FillArrayRandomNumbres(int[] array)
{
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(100);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

void CalculateSum(int[] array) {
    int evenSum = 0;
    for (int i = 0; i < array.Length; i++) {
        if (i % 2 != 0) {
            evenSum += array[i];
        }
    }

    Console.WriteLine("сумма нечетных: " + evenSum);
}