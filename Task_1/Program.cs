// Задайте массив заполненный случайными положительными трехзначными числами. 
// Напишите программу, которая покажет количество четных чисел в массиве. 
// [345, 897, 568, 234] -> 2


int[] numbers = new int[10];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);
CalculateEven(numbers);

void FillArrayRandomNumbres(int[] array)
{
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

void CalculateEven(int[] array) {
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            evenCount++;
        }
    }

    Console.WriteLine("количество четных: " + evenCount);
}



