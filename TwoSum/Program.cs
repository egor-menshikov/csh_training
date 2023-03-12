// Поиск двух элементов массива, которые в сумме будут давать число n.

int n = 47;
int[] array = {-1, 9, 31, 3, -6, 7, 0, 4, -5, 16};

int[] twoSum(int[] nums, int k) 
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == k)
            {
                return new int[]{nums[i], nums[j]};
            }
        }
    }
    return new int[0];
}
int[] answer = twoSum(array, n);
Console.WriteLine("[{0}]", string.Join(", ", answer));