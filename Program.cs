public class BinarySearch
{
    public int? SimpleBinarySearch(int[] list, int item)
    {
        int lowGuess = 0;
        int highGuess = list.Length - 1;

        while (lowGuess <= highGuess)
        {
            int middle = (lowGuess + highGuess) / 2;
            int guess = list[middle];
            if (guess == item)
            {
                return middle;
            }
            if (guess > item)
            {
                highGuess = middle - 1;
            }
            else
            {
                lowGuess = middle + 1;
            }
        }

        return null;
    }

    public static void Main()
    {
        int[] my_list = { 1, 3, 5, 7, 9 };

        BinarySearch search = new BinarySearch();
        int? result = search.SimpleBinarySearch(my_list, 7);

        Console.WriteLine(result.HasValue ? $"Item found at index: {result}" : "Item not found");
    }
}