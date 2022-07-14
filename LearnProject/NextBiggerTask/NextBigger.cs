
using System;
using System.Globalization;

namespace LearnProject.NextBiggerTask
{
    public static class NumberExtension
    {
        public static int? NextBiggerThan(int number)
        {
            var nums = number.ToString(CultureInfo.InvariantCulture).ToCharArray();

            if (number < 0 || number == int.MinValue)
            {
                throw new ArgumentException($"Value of {nameof(number)} cannot be less zero.");
            }
            else if (number == int.MaxValue)
            {
                return null;
            }

            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i - 1] < nums[i])
                {
                    int temp = nums[i];
                    nums[i] = nums[i - 1];
                    nums[i - 1] = (char)temp;

                    for (int k = i; k < nums.Length - 1; k++)
                    {
                        for (int j = k + 1; j < nums.Length; j++)
                        {
                            if (nums[k] > nums[j])
                            {
                                int t = nums[k];
                                nums[k] = nums[j];
                                nums[j] = (char)t;
                            }
                        }
                    }

                    return int.Parse(nums);
                }
            }

            return null;
        }
    }
}
