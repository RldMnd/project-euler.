using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E
{
    public static class Task3
    {
        static IEnumerable<long> GetPrime(long n)
        {
            var res = new List<long>();
            res.Add(2);
            for (var i = 3; i <= n; i++)
            {
                var isPrime = true;
                for(var j = 0; j < res.Count; j++)
                {
                    if (i % res[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) res.Add(i);
            }
            return res;
        }

        public static long Solve(long num)
        {
            var dt = DateTime.Now.Ticks;
            //Получаем список простых числе до х, где х*х=num
            var list = GetPrime((long)Math.Sqrt(num));
            list = list.Reverse();
            foreach(var i in list)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"Время {DateTime.Now.Ticks - dt}");
                    return i;
                }
            }

            Console.WriteLine($"Время {DateTime.Now.Ticks - dt}");
            return num;
        }

        public static long Solve2(long num)
        {
            var dt = DateTime.Now.Ticks;
            //Получаем список простых числе до х, где х*х=num
            var list = new List<long>();
            list.Add(2);
            var val = 3;
            var isPrime = true;
            while (val * val < num) {
                isPrime = true;
                foreach (var el in list){
                    if (val % el == 0)
                    {
                        isPrime = false;
                        val += 2;
                    }
                }
                if (isPrime)
                {
                    list.Add(val);
                    if (num % val == 0)
                    {
                        num /= val;
                    }
                }
            }

            Console.WriteLine($"Время {DateTime.Now.Ticks - dt}");
            return num;
        }
    }
}
