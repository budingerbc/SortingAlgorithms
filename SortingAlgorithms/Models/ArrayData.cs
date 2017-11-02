using System;
using System.Linq;

namespace SortingAlgorithms.Models
{
  public class ArrayData
  {
    private int[] _shuffledArray = new int[100];

    public ArrayData()
    {
      _shuffledArray = Enumerable.Range(1, 100).ToArray();
      Console.WriteLine(_shuffledArray);
    }
  }
}
