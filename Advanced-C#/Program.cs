using System;
using Advanced_C_;

namespace AdvancedC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            var range = new Range<int>(5, 15);

            Console.WriteLine(range);
            Console.WriteLine(range.Contains(10));
            Console.WriteLine(range.Length());


            #endregion





        }
    }
}
