// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N (включительно). Использовать рекурсию, не использовать циклы.

void printNums(int M, int N) {
  if (N < 0 & M < 0) {
    System.Console.WriteLine("Numb must be graiter then 0.");
  }
  if (N == M) {
    System.Console.WriteLine("The numbers are equal.");
    return;
  }

  if (N < M) {
    int temp = M;
    M = N;
    N = temp;
  }

  // System.Console.WriteLine(M + " " + N);
  // System.Console.WriteLine();

  if(N >= M & N > 0) {
    printNums(M, N - 1);
    Console.Write(N + " ");

  }
}
// 2 6 2 5 2 4 2 3

printNums(10, 10);

// void NaturNum(int n){
//     if (n > 0) {
//         NaturNum(n-1);
//         Console.Write(n + " ");
//     }
//     else if(n<0){
//         Console.WriteLine("Numb must be graiter then 0");
//     }    
// }

// NaturNum(-5);