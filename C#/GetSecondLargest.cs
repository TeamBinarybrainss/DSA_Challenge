class SecondLargest
{
    public static int GetSecondLargest(int[] arr)
    {
        int n = arr.Length;

        if (n < 2)
        {
            return -1; // Or throw an exception
        }

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if (arr[i] > secondLargest && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }

        // Handle case where all elements are same
        if (secondLargest == int.MinValue)
        {
            return -1;
        }

        return secondLargest;
    }
}
