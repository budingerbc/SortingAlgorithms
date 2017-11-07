using System;
using System.Linq;

namespace SortingAlgorithms.Models
{
    public class ArrayData
    {
        private int[] _arrayData;


        public ArrayData()
        {
            _arrayData = Enumerable.Range(1, 100).ToArray();
            this.ShuffleArray();

            Console.WriteLine(_arrayData);
        }

        // Using the Fisher - Yates shuffle algorithm
        // https://bost.ocks.org/mike/shuffle/
        public void ShuffleArray()
        {
            int m, i, temp;
            m = i = temp = _arrayData.Length;
            Random _random = new Random();

            while (m > 0)
            {
                // Finding a random element in the sorted portion of the array
                i = (int)Math.Floor(_random.NextDouble() * m--);
                // Assigning the value of the random index to a temporary value
                temp = _arrayData[m];
                // Swap the found value to the end of the array
                _arrayData[m] = _arrayData[i];
                // Swap the last sorted value in the array to the randomly selected index
                _arrayData[i] = temp;
            }
        }
    }
}
