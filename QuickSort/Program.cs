namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = MakeArray(20);
            Console.WriteLine(String.Join(", ", QuickSort(array, 0, 19)));
            Console.ReadLine();
        }

        private static int[] MakeArray(int length) 
        {
            var rnd = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
            return array;
        }
        private static int[] QuickSort(int[] array, int minIndex, int maxIndex) 
        {
            if(minIndex >= maxIndex)
                return array;

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }
        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex) 
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex]) 
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }
        private static void Swap(ref int leftItem, ref int rightItem) 
        {
            var temp = leftItem;
            leftItem = rightItem;
            rightItem = temp;
        }
    }
}