using Calculator;
using Selamla;

namespace SOAPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator asd = new BasicCalculator();
            int[] numbers1 = new int[] { 1, 2, 32, 35, 232, 32, 2, 32 };
            Console.WriteLine("Toplam: "+asd.Sum(numbers1));
            Selamlama asddsa = new Selamlama();
            string[] hellos = new string[] { "asds" + "efdsfd" + "sdsad" + "xscfdsfc" };
            Console.WriteLine("Hoşgeldiniz " +asddsa.SayHello(hellos));
            Console.ReadLine();

        }
    }
}
/* terimler, kullanımlar,   */