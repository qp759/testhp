using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int hp = 10;
            while (true)
            {
                if (hp <= 0)
                {
                    Console.WriteLine("oof");
                    break;
                }
                string input = Console.ReadLine();
                int attacke = int.Parse(input);
                hp = hp - attacke;
                Console.WriteLine(hp);
            }
            Console.ReadLine();
        }
    }
}
