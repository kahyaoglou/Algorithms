class Search
{
    public int IterativeBinarySearch(int[] A, int key)
    {
        // int[] A = { 15, 21, 47, 84, 96 }; 
        int left = 0;
        int right = A.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (key == A[mid])
            {
                return mid;
            }
            else if (key <= A[mid])
            {
                right = mid - 1;
            }
            else if (key > A[mid])
            {
                left = mid + 1;
            }
        }
        return -1;
    }

    public int RecursiveBinarySearch(int[] A, int key, int left, int right)
    {
        if(left > right)
        {
            return -1;
        }
        else
        {
            int mid = (left + right) / 2;
            if (key == A[mid])
                return mid;
            else if (key < A[mid])
            {
                return RecursiveBinarySearch(A, key, left, mid-1);
            }

            else if (key > A[mid])
            {
                return RecursiveBinarySearch(A, key, mid + 1, right);
            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        Search s = new Search();
        int[] A = { 15, 21, 47, 84, 96 };
        int foundIterative = s.IterativeBinarySearch(A, 96);
        Console.WriteLine("Result: " + foundIterative);

        int foundRecursive = s.RecursiveBinarySearch(A, 96, 0, 4);
        Console.WriteLine("Result: " + foundRecursive);
        Console.ReadKey();
    }
}