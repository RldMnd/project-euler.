namespace Project_E
{
    public static class Task2
    {
        public static long Solver(int num)
        {
            var dt = DateTime.Now.Ticks;
            long a=1,b = 1;
            long res = 0;
            while (b < num)
            {
                var c = a + b;
                if (c % 2 == 0)
                {
                    res += c;
                }
                a = b;
                b = c;
            }
            Console.WriteLine($"Время T1 {DateTime.Now.Ticks - dt}");
            return res;
        }
    }
}
