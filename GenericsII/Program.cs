using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsII
{
    class Program
    {
        static void Main(string[] args)
        {
            var jukeBox = new Jukebox<IMedia>();
            
            Play<string>("hello world");
        }

        static void Play<T>(T song)
        {

        }
    }
}
