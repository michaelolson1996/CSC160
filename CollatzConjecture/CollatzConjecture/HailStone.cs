using System;

namespace MyHailStone
{
    class HailStone
    {
        public int Number { get; set; }
        public HailStone(int number)
        {
            Number = number;
        }

        public void PrintSequence()
        {
            // Collatz Conjecture / 3x+1 problem
            // what - a mathematical problem that ends in the same loop { 4,2,1,4,2,1... }
            // who - Lothar Colatz
            // when - 1937
            // where - Germany
            // why - to push mathematics further by providing an impossible problem

            // 5 * 2^60 have been tried
            // 8 = 8,4,2,1
            // 3 = 10,5,16,8,4,2,1
            // even -> divide by 2
            // odd -> multiply by 3, add 1

            var currnum = Number;

            while (currnum != 1)
            {
                Console.Write($"{currnum}, ");
                if (currnum % 2 == 0)
                    currnum = currnum / 2;
                else
                    currnum = currnum * 3 + 1;
            }
            Console.WriteLine("1");
        }
    }
}