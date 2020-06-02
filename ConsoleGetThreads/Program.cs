using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGetThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.GetThread().ToString());
            
            Console.ReadKey();
        }

        public int GetThread()
        {
            int start = 1;
            int end = 100000;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (!IsBadSetting(mid))
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            if (!IsBadSetting(start))
                return start;
            return end;
        }

        public bool IsBadSetting(int n)
        {
            return ThreadPool.SetMinThreads(n, n);
        }
    }
}
