
sol1();
int sol1()
{
    int[] nums = { 1, 2, 3, 4, 5 };
    int target = 3;

    Solution1 sol = new Solution1();
    int[] answer = sol.TwoSum(nums, target);

    Console.WriteLine("[{0}]", string.Join(", ", answer));

    return 0;
}
public class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> solutionDictionary = new Dictionary<int, int>();

        int sizeofnums = nums.Length;

        for (int solution1 = 0; solution1 < sizeofnums; solution1++)
        {
            int solution2_key = target - nums[solution1];
            if (solutionDictionary.ContainsKey(solution2_key) && solutionDictionary[solution2_key] != solution1)
            {
                return [solution1, solutionDictionary[solution2_key]];
            }
            else
            {
                solutionDictionary.TryAdd(nums[solution1], solution1);
            }
        }
        return [];
    }
}