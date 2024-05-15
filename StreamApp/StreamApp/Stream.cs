using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamApp
{
    internal class Stream
    {
        public Watch Watching;
        public Stream(Watch watching) 
        {
            Watching = watching;
        }

        public void watch() 
        {
            Console.WriteLine(Watching.watch());
        }
    }
}
