int[] CreateArray(int max, int min, int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(min, max + 1);
  }
  return array;
}

double[] CreateDoubleArray(double max, double min, int size)
{
  double[] array = new double[size];
  if (min < 0)
  {
    for (int i = 0; i < size; i++)
    {
      array[i] = Math.Round((new Random().NextDouble() * (-max + min) + max), 2);
    }
  }
  else
  {
    for (int i = 0; i < size; i++)
    {
      double temp = Math.Round((new Random().NextDouble() * (max - min) + min), 2);
      array[i] = temp;
    }
  }

  return array;
}

void ShowArray(int[] array)
{

  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int countElements(int firstNum, int secondNum)
{
  int[] arr = CreateArray(100, 1, 10);

  ShowArray(arr); // Вспомогательный код

  int count = 0;
  if (firstNum > secondNum)
  {
    int temp = firstNum;
    firstNum = secondNum;
    secondNum = temp;
  }
  foreach (int el in arr)
  {
    if (el >= firstNum & el <= secondNum)
    {
      count++;
    }
  }
  return count;
}

Console.WriteLine(countElements(90, 20));


// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int countEvenElements(int maxNum, int minNum)
{
  int[] arr = new int[10];
  if (maxNum > minNum) {
    arr = CreateArray(maxNum, minNum, 10);
  } else {
    arr = CreateArray(minNum, maxNum, 10);
  }

  Console.WriteLine(string.Join(" ", arr));  // Вспомогательный код

  int count = 0;

  foreach (int el in arr)
  {
    if (el % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

Console.WriteLine(countEvenElements(-1000, 1000));

// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double differenceMimMax(int startValue, int endValue)
{
  double[] arr = CreateDoubleArray(startValue, endValue, 10);
  Console.WriteLine(string.Join(" ", arr)); // Вспомогательный код
  double min = arr[0];
  double max = arr[0];

  foreach (double el in arr)
  {
    if (el <= min)
    {
      min = el;
    }
    else if (el > max)
    {
      max = el;
    }
  }
  Console.WriteLine(min); // Вспомогательный код
  Console.WriteLine(max); // Вспомогательный код

  return Math.Round((max - min), 2);
}
Console.WriteLine(differenceMimMax(0, -50));


// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

void printDigits() {
  int num = new Random().Next(1, 100000 + 1); 

  System.Console.WriteLine(num); // Вспомогательный код
  
  string str = num.ToString();
  int [] arr = new int[str.Length];
  for (int i = 0; i < str.Length; i++) {
    char c = str[i];
    arr[i] = Int32.Parse(c.ToString());
  }
  Console.WriteLine(string.Join(" ", arr));
}

printDigits();