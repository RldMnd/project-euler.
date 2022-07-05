namespace Project_E
{
    public static class Task1
    {
        public static int Solve(int n)
        {
            var dt = DateTime.Now.Ticks;
            var sum = 0;
            for(var i = 1; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            Console.WriteLine(DateTime.Now.Ticks-dt);
            return sum;
        }
    }
}
