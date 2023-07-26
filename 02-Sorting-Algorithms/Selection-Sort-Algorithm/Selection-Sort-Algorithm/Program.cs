class Sort
{
    public void SelectionSort(int[] A)
    {
        for (int i = 0; i < A.Length - 1; i++)
        {
            //int[] A = { 3, 5, 8, 9, 6, 2 };
            int position = i;
            for (int j = i + 1; j < A.Length; j++)
            {
                if (A[j] < A[position])
                {
                    position = j;
                }
            }
            int temp = A[i];
            A[i] = A[position];
            A[position] = temp;
        }
    }

    public void display(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            Console.WriteLine(A[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Sort s = new Sort();
        int[] A = { 3, 5, 8, 9, 6, 2 };
        Console.WriteLine("Original Array: ");
        s.display(A);


        Console.WriteLine("Sorted Array: ");
        s.SelectionSort(A);
        s.display(A);
        Console.ReadKey();
    }
}