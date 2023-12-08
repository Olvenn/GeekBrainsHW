using System.Security.AccessControl;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void ShowCharsArr(char [] chars){
    foreach(char elem in chars){
        Console.Write(elem+" ");
    }
}

void Show2dCharsArr(char [,] chars){
    foreach(char elem in chars){
        Console.Write(elem+" ");
    }
}

// char [] chars = {'a','d','c','b'};
// ShowCharsArr(chars);

char[,] Create2dArray(int row, int col, char[] charArray)
{
  char[,] array = new char[row, col];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      char randomChar = charArray[new Random().Next(1, charArray.Length - 1)];
      array[i, j] = randomChar;
    }
  }
  return array;
}

char[] letters = Enumerable.Range('A':'F', 26 - 2).
                  Select(c => (char) c).ToArray();

char[] letters2 = Enumerable.Range('A', 'z' - 'Z' + 1).
                     Select(c => (char)c).ToArray();
char[] alphabet = Enumerable.Range('Z', 36).Select(x => (char)x).ToArray();
                  // Enumerable.Range('A', 26).Cast<char>()
ShowCharsArr(letters);
System.Console.WriteLine();
// ShowCharsArr(alphabet);
System.Console.WriteLine();

char[,] char2dArray = Create2dArray(3, 3, letters);
Show2dCharsArr(char2dArray);

System.Console.WriteLine();

// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

string createStringFromArray(char[,] arrayIn) {
   string res = "";
    foreach (char elem in arrayIn){
        res += elem;
    }

  return res;

}
 Console.WriteLine(createStringFromArray(char2dArray));