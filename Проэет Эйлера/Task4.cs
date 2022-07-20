namespace Project_E
{
    public static class Task4
    {
        static bool isPalindrome(long num)
        {
            var s=num.ToString();
            var len = s.Length;
            for (var i = 0; i <  len/ 2; i++)
            {
                if (s[i] != s[len - i - 1]) return false;
            }
            return true;
        }
        /// <summary>
        /// Поиск самого большого числа-палиндрома
        /// </summary>
        /// <param name="count">Колво цифр в множителях</param>
        /// <returns></returns>
        public static long Solve(int count)
        {
            var dt = DateTime.Now.Ticks;
            var list = new List<long>();
            long a, b, end;
            a = b = (long)Math.Pow(10,count) - 1;
            end = (long)Math.Pow(10, count-1);
            for (var i=a; i > end; i--)
            {
                for(var j = b; j > end; j--)
                {
                    if (isPalindrome(i * j))
                    {

                        list.Add(i * j);                    }
                }
            }
            Console.WriteLine($"Время {DateTime.Now.Ticks - dt}");
            return list.Max();
        }
    }
}
