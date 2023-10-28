using System.Collections.Concurrent;

class Sort
{
    public void QuickSort(int[] A, int low, int high)
    {
        if(low  < high)
        {
            int pi = Partition(A, low, high);
            QuickSort(A, low, pi - 1);
            QuickSort(A, pi + 1, high);
        }
    }

    public int Partition(int[] A, int low, int high)
    {
        int pivot = A[low];
        int i = low + 1;
        int j = high;
        do
        {
            while (i <= j && A[i] <= pivot)
            {
                i = i + 1;
            }

            while (i <= j && A[j] > pivot)
            {
                j = j - 1;
            }

            if(i <= j)
            {
                Swap (A, i, j);
            }
        } while (i < j);
        Swap(A, low, j);
        return j;
    }

    public void Swap(int[] A, int i, int j)
    {
        int temp = A[i];
        A[i] = A[j];
        A[j] = temp;
    }

    public void Display(int[] A, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
    }


    static void Main(string[] args)
    {
        Sort s = new Sort();
        int[] A = { 3, 5, 8, 9, 6, 2 };
        Console.WriteLine("Original Array: ");
        s.Display(A, 6);

        Console.WriteLine("Sorted Array: ");
        s.QuickSort(A, 0, 5);
        s.Display(A, 6);
        Console.ReadKey();
    }
}