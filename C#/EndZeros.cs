class EndZeros
{
    public static void PushZeroToEnd(int[] nums)
    {
        int n = nums.Length;
        int nonZeroIndex = 0;

        for (int current = 0; current < n; current++)
        {
            if (nums[current] != 0)
            {
                nums[nonZeroIndex] = nums[current];
                nonZeroIndex++;
            }
        }

        for (int i = nonZeroIndex; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
        
    }
}