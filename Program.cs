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

    public int? SimpleBinarySearchForString(string[] list, string target)
    {
        int lowGuess = 0;
        int highGuess = list.Length - 1;

        while (lowGuess <= highGuess)
        {
            int middle = (lowGuess + highGuess) / 2;
            string guess = list[middle];

            int comparison = string.Compare(guess, target, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0) 
            {
                return middle;
            }
            else if (comparison > 0) 
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
        int? result = search.SimpleBinarySearch(my_list, 4);

        Console.WriteLine(result.HasValue ? $"Item found at index: {result}" : "Item not found");


        string[] names =
    {
        "Alice", "Bob", "Charlie", "Diana", "Eve", "Frank", "Grace", "Hank", "Ivy", "Jack",
        "Karen", "Liam", "Mona", "Nate", "Olivia", "Paul", "Quincy", "Rachel", "Sam", "Tina",
        "Uma", "Victor", "Wendy", "Xander", "Yara", "Zane", "Anna", "Ben", "Cara", "David",
        "Ella", "Finn", "Gina", "Harry", "Isla", "James", "Kara", "Leo", "Mia", "Noah",
        "Oscar", "Piper", "Quinn", "Riley", "Sophie", "Thomas", "Ursula", "Violet", "Will", "Xena",
        "Yuri", "Zara", "Adrian", "Bella", "Caleb", "Daisy", "Ethan", "Fiona", "Gavin", "Hazel",
        "Ian", "Julia", "Kyle", "Lila", "Mason", "Nina", "Owen", "Phoebe", "Quinton", "Ruby",
        "Simon", "Tara", "Ulysses", "Vanessa", "Wyatt", "Xiomara", "Yvette", "Zack", "Aiden", "Brooke",
        "Chase", "Delilah", "Elliot", "Faith", "George", "Holly", "Isaac", "Jade", "Kieran", "Lydia",
        "Miles", "Natalie", "Oliver", "Paige", "Quentin", "Rebecca", "Sebastian", "Taylor", "Ulrich", "Vivian",
        "Walker", "Xander", "Yvonne", "Zion", "Arthur", "Bridget", "Cody", "Danielle", "Edward", "Felicity",
        "Grant", "Hannah", "Iris", "Justin", "Kayla", "Logan", "Megan", "Nathan", "Orla", "Parker",
        "Quinlan", "Rose", "Scott", "Tracy", "Uma", "Victor", "Willow", "Ximena", "Yves", "Zane"
    };
        Array.Sort(names);


        string target = "Justin";
        int? resultString = search.SimpleBinarySearchForString(names, target);

        if (resultString.HasValue)
        {
            Console.WriteLine($"Name '{target}' found at index: {resultString}");
        }
        else
        {
            Console.WriteLine($"Name '{target}' not found.");
        }


    }
}