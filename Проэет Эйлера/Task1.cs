namespace Project_E
{
    public static class Task1
    {
        /// <summary>
        /// Полным перебором
        /// </summary>
        /// <param name="n">Верхняя граница</param>
        /// <returns></returns>
        public static int Solve(int n)
        {
            var dt = DateTime.Now.Ticks;
            var sum = 0;
            for(var i = 1; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            Console.WriteLine($"Время T1 {DateTime.Now.Ticks - dt}");
            return sum;
        }

        /// <summary>
        /// Решение через формулу
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Solve2(int num)
        {
            var dt = DateTime.Now.Ticks;
            num--;
            var n1 = num / 3;
            var n2 = num / 5;
            var n3 = num / 15;
            var sum = 3*(n1+1)*n1/2.0+5*(n2+1)*n2/2.0-15*(n3+1)*n3/2.0;
            Console.WriteLine($"Время T2 {DateTime.Now.Ticks - dt}");
            return (int) sum;
        }
    }
}
