using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BubbleSort
    {
        public static void SortJuggedArray(int[][] arr, Func<int[], int> parameter, bool ascending = true)
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }
            if (parameter == null)
            {
                throw new ArgumentNullException(nameof(parameter));
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (parameter(arr[i]) <= parameter(arr[j]) && ascending) continue;
                    if (parameter(arr[i]) >= parameter(arr[j]) && !ascending) continue;
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        public static int MaxParameter(int[] arr)
        {
            return arr.Max();
        }

        public static int MinParameter(int[] arr)
        {
            return arr.Min();
        }

        public static int SumParameter(int[] arr)
        {
            return arr.Sum();
        }

    }
}
