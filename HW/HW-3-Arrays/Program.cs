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
  for (int i = 0; i < size; i++)
  {
    array[i] = Math.Round((new Random().NextDouble() * (max + min) - min), 2);
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

// var str = string.Join(" ", arr);
// Console.WriteLine(str);

int countElements(int firstNum, int secondNum)
{
  int[] arr = CreateArray(100, 1, 10);
  Console.WriteLine(string.Join(" ", arr));
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

// Console.WriteLine(countElements(90, 20));

int countEvenElements()
{
  int[] arr = CreateArray(100, -100, 10);
  Console.WriteLine(string.Join(" ", arr));
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

// Console.WriteLine(countEvenElements());


var str2 = string.Join(" ", CreateDoubleArray(100, 1, 10));
Console.Write(str2);

double differenceMimMax()
{
  double[] arr = CreateDoubleArray(100, 1, 10);
  doubleMin =
}
