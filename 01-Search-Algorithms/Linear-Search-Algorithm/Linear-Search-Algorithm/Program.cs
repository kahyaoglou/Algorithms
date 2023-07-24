class Search
{
    public int linearSearch(int[] A, int key)
    {
        int index = 0;
        while (index < A.Length)
        {
            if (A[index] == key)
            {
                return index; //Kaçıncı satırdaysa onu döndür.
            }

            index = index + 1;
        }
        return -1;
    }


    static void Main(string[] args)
    {
        Search s = new Search();
        int[] A = { 84, 21, 47, 96, 15 };
        int found = s.linearSearch(A, 96);
        Console.WriteLine("Result: " + found);
        /*Eğer dizide aranan değer yoksa, found değeri -1 olur.
                    Çünkü return -1 dedik.*/
        Console.ReadKey();
    }
}