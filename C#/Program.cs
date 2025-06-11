class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 2, 3, 4, 5, 6 };
        int result = SecondLargest.GetSecondLargest(arr);
        Console.WriteLine(result);

        int[] arr2 = { 0, 1, 0, 3, 12 };
        
        // Call the method (which modifies the array in-place)
        EndZeros.PushZeroToEnd(arr2);
        
        // Print the modified array
        Console.WriteLine(string.Join(", ", arr2));
    }
}
