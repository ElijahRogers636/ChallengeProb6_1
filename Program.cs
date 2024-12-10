namespace ChallengeProb6_1
{
    internal class Program
    {
        //Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
        static void Main(string[] args)
        {
            //Assume int array has at least one element
            //All elements appear twice
            //Find the element that does not appear twice

            int[] intArr = { 1, 1, 3, 3, 6, 6, 7, 8, 8 };
            Console.WriteLine($"Single Element found: { FindDistinctElem(intArr)}");
            
        }

        // Uses a dictionary to keep count of elements, search for and return the key based on a value on 1
        public static int FindDistinctElem(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            
            foreach(int i in arr)
            {
                if(!dict.TryAdd(i, 1))
                {
                    dict[i]++;
                }
            }

            foreach(var (key, value) in dict)
            {
                if(value == 1)
                {
                    return key;
                }
            }

            return -1;
        }
    }
}
