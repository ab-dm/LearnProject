using System;

namespace LearnProject.StringVerification
{
    public static class IsbnVerifier
    {
        public static bool IsValid(string number)
        {
            if (number is null || number.Length == 0)
            {
                throw new ArgumentException("Source string cannot be null or empty or whitespace.");
            }

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == ' ')
                {
                    throw new ArgumentException("Source string cannot be null or empty or whitespace.");
                }
            }

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '-' && number[i + 1] == '-')
                {
                    return false;
                }
            }

            bool isValid = false;
            int checkSum = 0;
            int count = 10;

            string[] vs = number.Split('-');
            string vs2 = string.Join(null, vs);

            if (vs2.Length != 10)
            {
                return isValid;
            }

            if (vs.Length <= 4)
            {
                for (int i = 0; i < vs2.Length; i++)
                {
                    if (vs2[i] == 'X' && vs2[^1] != 'X')
                    {
                        return isValid;
                    }

                    checkSum += vs2[i] switch
                    {
                        '0' => count-- * 0,
                        '1' => count-- * 1,
                        '2' => count-- * 2,
                        '3' => count-- * 3,
                        '4' => count-- * 4,
                        '5' => count-- * 5,
                        '6' => count-- * 6,
                        '7' => count-- * 7,
                        '8' => count-- * 8,
                        '9' => count-- * 9,
                        'X' => count-- * 10,
                        _ => -1000,
                    };
                }
            }
            else
            {
                return isValid;
            }

            if (checkSum % 11 == 0)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
