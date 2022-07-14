namespace LearnProject.HelloWorldStyle
{
    public static class HelloWorld
    {
        public static string ReturnGreeting(string hello, string addressee)
        {
            return hello + ", " + addressee + "!";
        }

        public static int ReturnSum(int a, int b)
        {
            return a + b;
        }

        public static int[] ReturnArray(int length)
        {
            var array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = i;
            }

            return array;
        }
    }
}
