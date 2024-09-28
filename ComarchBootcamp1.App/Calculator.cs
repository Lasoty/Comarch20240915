namespace ComarchBootcamp1.App
{
    internal class Calculator
    {
        public int Add(params int[] values)
        {
            int result = 0;
            foreach (int i in values)
            {
                result += i;
            }
            return result;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        internal int Subtract(int x, int y)
        {
            return x - y;
        }

        internal int Multiply(int x, int y)
        {
            return x * y;
        }

        internal float Dividy(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Pamiętaj cholero! Nie dziel przez 0!");
            }

            return (float)x / y;
        }

        internal float Modulo(int x, int y)
        {
            return (float)x % y;
        }
    }
}
