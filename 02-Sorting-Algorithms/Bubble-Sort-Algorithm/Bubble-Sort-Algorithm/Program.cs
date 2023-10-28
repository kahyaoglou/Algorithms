class Sort
{
    public void BubbleSort(int[] A)
    {
        for(int pass = A.Length - 1; pass >= 0; pass--)
        {
            for (int i = 0; i < pass; i++)
            {
                if (A[i] > A[i + 1])
                {
                    int temp = A[i];
                    A[i] = A[i + 1];
                    A[i + 1] = temp;
                }
            }
        }
    }

    public void Display(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
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
        s.Display(A);

        Console.WriteLine("Sorted Array: ");
        s.BubbleSort(A);
        s.Display(A);
        Console.ReadKey();
    }
}