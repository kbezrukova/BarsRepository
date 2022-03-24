using System;

namespace BarsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex = new Example();
            ex.OnKeyPressed += Print;
            ex.Run();

            void Print(object sender, char x)
            {
                Console.WriteLine("\n Your symbol: " + x);
            }
        }
    }

    public class Example
    {
        public event EventHandler<char> OnKeyPressed;

        public void Run()
        {
            while (true)
            {
                var x = Console.ReadKey().KeyChar;
                if(x !='c')
                {
                    OnKeyPressed?.Invoke(this, x);
                }
                else { break; }
            }
        }
    }
}
