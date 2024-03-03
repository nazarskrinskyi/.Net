namespace ExtendedMath
{
    public static class EMath
    {
        public static float Factorial(float value)
        {
            int integer = (int)Math.Round(value);

            if (integer < 0)
                return 0;

            float result = 1;
            for (int i = 1; i <= integer; i++)
                result *= i;

            return result;
        }

        public static float Cotan(float value)
        {
            return MathF.Cos(value) / MathF.Sin(value);
        }

        public static float ConvertToRadian(float value)
        {
            return value * MathF.PI / 180;
        }
    }
}
