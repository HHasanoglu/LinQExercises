using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.MethodSyntax
{
    public static class LamdaExpression
    {

        //private IEnumerable<int> numbers;

        //public LamdaExpression(IEnumerable<int> numbers)
        //{
        //    this.numbers = numbers;
        //}

        public static void Run()
        {
            var numbers = new[] { 1, 4, 3, 99, 101, 105, 603 };
            var names = new[] { "Hamid", "Ali","Mahdi"};
            //bool result = IsAny(numbers, IsLargerThan100);
            bool result = IsAny(numbers,number => number>100 && number%2==0);
            Console.WriteLine(result);
            Console.WriteLine(IsAny(names,name=>name.Length>5));


        }

        public static bool IsAny<T>(IEnumerable<T> data, Func<T, bool> function)
        {
            foreach (var item in data)
            {
                if (function(item))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsLargerThan100(int number)
        {
            return number > 100;
        }


        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }



        private static bool isAnyNumberEven(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (IsEven(number))
                {
                    return true;
                }
            }
            return false;
        }


        private static bool isAnyNumberLargerthan100(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (IsLargerThan100(number))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
