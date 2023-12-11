using System.Security.AccessControl;

void ShowCharsArr(char[] chars)
{
  foreach (char elem in chars)
  {
    Console.Write(elem + " ");
  }
}

void ShowWordsArr(string[] words)
{
  foreach (string elem in words)
  {
    Console.Write(elem + " ");
  }
}

void Show2dCharsArr(char[,] chars)
{
  foreach (char elem in chars)
  {
    Console.Write(elem + " ");
  }
}

char[] CreateArray(int size, char[] charArray)
{
  char[] array = new char[size];
  for (int i = 0; i < size; i++)
  {
    char randomChar = charArray[new Random().Next(1, charArray.Length - 1)];
    array[i] = randomChar;
  }
  return array;
}

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

string[] CreateWordsArray(int size, string[] wordsArray)
{
  string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
      string randomChar = wordsArray[new Random().Next(1, wordsArray.Length - 1)];
      array[i] = randomChar;
    }
  return array;
}

char[] letters = Enumerable.Range('a', 'z' - 'a' + 1).
                 Select(c => (char)c).ToArray();

char[] letters2 = Enumerable.Range('A', 'Z' - 'A' + 1).
                  Select(c => (char)c).ToArray();

char[] createCharArray(char start, char finish) {
  char[] chars = Enumerable.Range(start, finish - start + 1).
                 Select(c => (char)c).ToArray();
  return chars;            
}

System.Console.WriteLine();
char[] alphabet = createCharArray('a', 'z').Concat(createCharArray('A', 'Z')).ToArray();

// Задайте двумерный массив символов (тип char [,]). 
char[,] char2dArray = Create2dArray(3, 3, alphabet);
Show2dCharsArr(char2dArray);
System.Console.WriteLine();
// Создать строку из символов этого массива.

string createStringFromArray(char[,] arrayIn)
{
  string res = "";
  foreach (char elem in arrayIn)
  {
    res += elem;
  }

  return res;
}

Console.WriteLine(createStringFromArray(char2dArray));
System.Console.WriteLine();

// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.
string lowerLetters = createStringFromArray(char2dArray).ToLower();

System.Console.WriteLine(lowerLetters);

// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

string anyString = string.Join("", CreateArray(4, createCharArray('"', '~')));
string shortString = string.Join("", CreateArray(4, createCharArray('a', 'd')));

bool IsPalindrome(string str)
{
  System.Console.WriteLine(str);

  if (str.Length == 1) {
    return true;
  }

  if (str.Length == 2) {
    return (str[0] == str[str.Length - 1]) ? true : false;
  }

  if (str.Length > 2 && (str[0] != str[str.Length - 1])) {
    return false;
  }

  return IsPalindrome(str.Substring(1, str.Length - 2));

}
Console.Write(IsPalindrome(shortString));
System.Console.WriteLine();



// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

string temp = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

string[] wordsIncomeArray = temp.Split(' ').Distinct().ToArray();

string[] reverseArray(int size, string[] array) {
  string[] incomeArray = CreateWordsArray(size, array);
  ShowWordsArr(incomeArray);
  System.Console.WriteLine();

  string[] newArr = (string[])incomeArray.Clone();
  Array.Reverse(newArr);

  return newArr;
}

ShowWordsArr(reverseArray(5, wordsIncomeArray));
System.Console.WriteLine();




