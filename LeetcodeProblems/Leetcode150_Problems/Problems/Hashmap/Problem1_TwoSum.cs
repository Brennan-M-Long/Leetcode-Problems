using System;

namespace Problem1;

public class TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        int End = nums.Length;
        for (int i = 0; i < End; i++)
        {
            for (int j = i + 1; j < End; j++)
            {
                switch (nums[i] + nums[j])
                {
                    case int sum when sum == target:
                        return new int[] { i, j };
                }
            }
        }
        return [0,0];
    }
}