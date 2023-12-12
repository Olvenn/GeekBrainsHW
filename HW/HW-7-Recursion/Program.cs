using System;

// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N (включительно). Использовать рекурсию, не использовать циклы.

void printNums(int M, int N) {
   if (N <= 0 & M <= 0) {
    System.Console.WriteLine("Numbs must be graiter then 0.");
  }

  if (N < M) {
    int temp = M;
    M = N;
    N = temp;
  }

  if (M < 1) {
    M = 1;
  }

  if(N > M & M > 0) {
    Console.Write(M + " " + N);
    printNums(M + 1, N);
  } else if (N == M)
  {
    Console.Write(M + " ");
  }
}

printNums(0, 0);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int m, int n) {
  if(m < 0 | n < 0) {
    return 0;
  }
  if (m == 0) {
    return n + 1;
  } else if ((m != 0) && (n == 0)) {
      return Ackermann(m - 1, 1);
      // 3 - 1, 1
    } else {
    return Ackermann(m - 1, Ackermann(m, n - 1));
    
    }
}

System.Console.WriteLine(Ackermann(3, 2)); // 29
System.Console.WriteLine();

// в Презентации m = 2, n = 3 - A(m, n) = 29 

int A(int m, int n)
{
  if (n == 0)
    return m + 1;
  else 
    if ((n!= 0) && (m == 0))
      return A(1, n - 1);

    else
      return A(A(m - 1, n), n - 1);
  return 10;
}
System.Console.WriteLine(A(2, 3));

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreateArray(int max, int min, int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(min, max + 1);
  }
  return array;
}

System.Console.WriteLine();

int[] incomeArray = CreateArray(10, 1, 5);

Console.WriteLine(string.Join(" ", incomeArray));

void PrintArray(int[] incomeArray) {

  if (incomeArray.Length > 0) {
    Console.Write(incomeArray[incomeArray.Length - 1] + " ");
    PrintArray(incomeArray.SkipLast(1).ToArray());
  }
}

PrintArray(incomeArray);
