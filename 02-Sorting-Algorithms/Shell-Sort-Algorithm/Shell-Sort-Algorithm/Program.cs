class Sort
{
    public void ShellSort(int[] A)
    {
        //int[] A = { 3, 5, 8, 9, 6, 2 };
        int gap = A.Length;
        while(gap > 0)
        {
            int i = gap;
            while (i < A.Length)
            {
                int temp = A[i];
                int j = i - gap;

                while(j >= 0 && A[j] > temp)
                {
                    A[j + gap] = A[j];
                    j = j - gap;
                }

                A[j + gap] = temp;
                i = i + 1;
            }

            gap = gap / 2;
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
        s.ShellSort(A);
        s.Display(A);
        Console.ReadKey();
    }
}