namespace fizzBuzz;

class Program
{
  static void Main(string[] args)
  {
    foreach (string item in FizzBuzz(100, 6, 8))
    {
      Console.Write($"{item} ");
    }
  }
  static string[] FizzBuzz(int length, int fizzNum, int buzzNum)
  {
    string[] newArray = new string[length];
    for (int i = 0; i < length; i++)
    {
      string arrayElement = Convert.ToString(i + 1);
      if ((i + 1) % fizzNum == 0 && (i + 1) % buzzNum == 0)
      {
        arrayElement = "FizzBuzz";
      }
      else if ((i + 1) % fizzNum == 0)
      {
        arrayElement = "Fizz";
      }
      else if ((i + 1) % buzzNum == 0)
      {
        arrayElement = "Buzz";
      }
      newArray[i] = arrayElement;
    }
    return newArray;
  }
}
