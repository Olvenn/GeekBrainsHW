// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[,] Create2dArray(int row, int col, int min, int max)
{
  int[,] array = new int[row, col];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      array[i, j] = new Random().Next(min, max + 1);
    }
  }
  return array;
}

// Console.WriteLine("str" + string.Join(" ", xx));
void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] testArray = Create2dArray(4, 5, 1, 100);
// Show2dArray(testArray);

// // Задача 1: 
// int findElement(int a, int b, int[,] arr)
// {
//   if ((a >= 0 & a < (arr.GetLength(0))) &
//       (b >= 0 & b < (arr.GetLength(1))))
//   {
//     return arr[a, b];
//   }
//   else
//   {
//     Console.WriteLine("Нет элемента с такой позицией.");
//     return -1;
//   }
// }

// System.Console.WriteLine("findElement  " + findElement(3, 3, testArray));
// System.Console.WriteLine();

// // Задача 2: Задайте двумерный массив. Напишите программу, 
// // оторая поменяет местами первую и последнюю строку массива.

// // Вариант 1 - с изменением исходного массива
// int[,] ChangeRowsArr(int[,] arr)
// {
//   for (int i = 0; i < arr.GetLength(1); i++)
//   {
//     int j = arr.GetLength(0);
//     int temp = arr[0, i];
//     // System.Console.WriteLine(temp);
//     arr[0, i] = arr[arr.GetLength(0) - 1, i];
//     arr[arr.GetLength(0) - 1, i] = temp;
//   }

//   return arr;
// }
// ChangeRowsArr(testArray);
// System.Console.WriteLine("after ChangeRowsArr");

// System.Console.WriteLine();
// Show2dArray(testArray);

// // Вариант 2 с созданием клона начального массива, без изменения исходного.
// int[,] ChangeRowsInNewArr(int[,] arr)
// {
//   int[,] newArr = (int[,])arr.Clone();

//   for (int i = 0; i < newArr.GetLength(1); i++)
//   {
//     int j = newArr.GetLength(0) - 1;
//     int temp = newArr[0, i];
//     newArr[0, i] = newArr[j, i];
//     newArr[j, i] = temp;
//   }
//   return newArr;
// }

// System.Console.WriteLine();
// System.Console.WriteLine("before ChangeRowsInNewArr");
// Show2dArray(testArray);
// int[,] arr2 = ChangeRowsInNewArr(testArray);
// System.Console.WriteLine("after ChangeRowsInNewArr");
// Show2dArray(arr2);

// // Вариант 3 с заполнением пустого массива.
// int[,] ChangeRowsInNewArr2(int[,] arr)
// {
//   int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];

//   for (int i = 1; i < newArr.GetLength(0) - 1; i++)
//   {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//       newArr[i, j] = arr[i, j];
//     }
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//       newArr[0, j] = arr[arr.GetLength(0) - 1, j];
//       newArr[arr.GetLength(0) - 1, j] = arr[0, j];
//     }
//   }

//   return newArr;
// }

// System.Console.WriteLine();
// System.Console.WriteLine("before ChangeRowsInNewArr2");
// Show2dArray(testArray);
// int[,] arr3 = ChangeRowsInNewArr2(testArray);
// System.Console.WriteLine("after ChangeRowsInNewArr2");
// Show2dArray(arr3);




// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[] FindRow()
// {
//   int[,] array = Create2dArray(8, 2, 1, 5);
//   int count = 0;
//   int[] rowIndex = new int[1];

//   Show2dArray(array);

//   for (int i = 0; i < array.GetLength(1); i++)
//   {
//     count += array[0, i];
//   }


//   for (int i = 1; i < array.GetLength(0); i++)
//   {
//     int rowCount = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       rowCount += array[i, j];
//     }

//     System.Console.WriteLine("rowCount" + rowCount + " " + count);

//     if (rowCount < count)
//     {
//       count = rowCount;
//       rowIndex[0] = i;
//     }
//     else if (rowCount == count)
//     {
//       int length = rowIndex.Length + 1;
//       System.Console.WriteLine("==");
//       Array.Resize(ref rowIndex, length);
//       rowIndex[rowIndex.Length - 1] = i;
//     }
//   }

//   return rowIndex;
// }

// System.Console.WriteLine();
// int[] minRows = FindRow();
// Console.WriteLine("Row indexes  " + string.Join(" ", minRows));
// System.Console.WriteLine();

Show2dArray(testArray);

// Задача 4
int[,] removeRowAndColFromArray(int[,] array)
{
  int min = array[0, 0];
  int rowIndex = 0;
  int colIndex = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (min > array[i, j])
      {
        rowIndex = i;
        colIndex = j;
        min = array[i, j];
      }
    }
  }
  int[,] resArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
  int x = -1;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int y = 0;

    if (i == rowIndex)
    {

      continue;
    }
    else
    {
      x++;
    }
    for (int j = 0; j < array.GetLength(1); j++)
      if (j == colIndex)
      {
        continue;
      } else {
        resArray[x, y] = array[i, j];
        y++;
      }
  }
  System.Console.WriteLine(min);
  return resArray;
}

Show2dArray(removeRowAndColFromArray(testArray));
