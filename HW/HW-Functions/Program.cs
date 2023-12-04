void GetNum() {
  Console.WriteLine("Print an integer number.");
  string input = Console.ReadLine();

  if(input.Equals("q")) {
    System.Console.WriteLine("q");
    return;
  } 
  if(int.TryParse(input, out _) ) {

    if(Int32.Parse(input) % 2 == 0) {

      return;
      }
  } 
      GetNum();

}

GetNum();

int[] CreateArray(int max, int min, int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(min, max + 1);
  }
  return array;
}

int CountOdd(int max, int min, int size) {
  int[] arr = CreateArray(max, min, size);
  int count = 0;
  Console.WriteLine(string.Join(" ", arr));
  foreach(int el in arr) {
    if(el % 2 == 0) {
      count++;
    }
  }
  return count;
}

System.Console.WriteLine(CountOdd(1000, 100, 10));

int[] testArr = CreateArray(100, 1, 10);

int[] ReverseArr(int[] arr) {
  int[] reverseArr = new int[arr.Length];
  int j = 0;
  Console.WriteLine(string.Join(" ", testArr));
  for (int i = arr.Length - 1; i >= 0; i--) {
    reverseArr[j] = arr[i];
    j++;
  }
  return reverseArr;
}
  Console.WriteLine(string.Join(" ", ReverseArr(testArr)));