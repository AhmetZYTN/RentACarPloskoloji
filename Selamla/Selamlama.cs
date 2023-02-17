using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selamla
{
    public class Selamlama
    {
        public string SayHello(string[] message)
        {

            for (int i = 0; i < message.Length; i++)
            {
                int sayi = message[i];
                Console.WriteLine(sayi + "Hoşgeldiniz mi?");

            }
            
        }
    }
}
