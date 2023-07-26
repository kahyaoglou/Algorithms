class Sort
{
    public void InsertionSort(int[] A)
    {
        for(int i = 1; i < A.Length; i++)
        {
            //int[] A = { 3, 5, 8, 9, 6, 2 };
            int temp = A[i];
            int position = i;

            while(position > 0 && A[position - 1] > temp)
            {
                A[position] = A[position - 1];
                position = position - 1;
            }

            A[position] = temp;
        }
    }

    public void Display(int[] A)
    {
        for(int i = 0; i < A.Length; i++)
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

        Console.WriteLine("Sorted Array:");
        s.InsertionSort(A);
        s.Display(A);

        Console.ReadKey();
    }
}