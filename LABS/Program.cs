using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song MySong = new Song("Город под подошвой","Оксимирон");
            Console.WriteLine(MySong.Title());
        }
    }
}
