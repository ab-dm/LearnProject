using System;

namespace LearnProject.ArithmeticSequenceTest
{
    public class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("The count of elements of the sequence cannot be less or equals zero.");
            }

            if (number == int.MaxValue || number == int.MinValue)
            {
                throw new OverflowException("The obtained result out of range of integer values.");
            }

            int sum = 0;

            for (int i = 0; i <= count - 1; i++)
            {
                sum += number + add * i;
            }

            return sum;
        }
    }
}
