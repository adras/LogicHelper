using LogicHelperLib;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(LogicHelper.True);
            }
            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(LogicHelper.IsMaybeTrue(true));
            }
            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(LogicHelper.IsMaybeFalse(true));
            }
            Console.WriteLine("");
        }
    }
}