// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace BankManagement
{
    class Program
    {
        static void Main()
        {
            LoopLearn loopLearn = new LoopLearn();
            loopLearn.fibonacci();
        }

    }
    class LoopLearn
    {

        public void Reversenum()
        {
            int a = 12340;
            int d = a;
            int e = 1;
            int c = 0;
            do
            {
                c = d % 10;
                e = d / 10;
                d = e;
                Console.Write(c);
            }
            while (e != 0);
        }

        public void sumofnums()
        {
            int numb = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= numb; i++)
            {
                sum += i;

            }
            Console.WriteLine(sum);
        }

        public void sumofdigits()
        {
            int numb = Convert.ToInt32(Console.ReadLine());
            int numb2 = numb;
            int e = 1;
            int c = 0;
            int result = 0;

            do
            {

                c = numb2 % 10;
                e = numb2 / 10;
                numb2 = e;
                result += c;

            }
            while (e != 0);
            Console.WriteLine(result);
        }

        public void fibonacci()
        {
            int numb = 20;
            int total = 0;

            do
            {

                Console.WriteLine(i);

            }
            while (total <= 20);

        }

    }


}