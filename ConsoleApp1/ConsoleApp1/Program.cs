using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.將所有號碼都放入List之中

            List<int> numbers = new List<int>();
            for (int i = 1; i <= 42; i++)
            {
                numbers.Add(i);
            }

            // 2.產生亂數物件

            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {

                // 3.隨機挑選其中一個印出
                int n = rand.Next(1, numbers.Count);
                Console.WriteLine(numbers[n] + " ");

                // 4.並從List之中刪除

                numbers.RemoveAt(n);
            }

            // 5.暫停螢幕
            Console.ReadLine();
        }
    }
}