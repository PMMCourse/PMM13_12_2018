using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsII
{
    public class Jukebox
    {
        
    }

    public class Jukebox<T,V> where T : IMedia        
    {

    }

    public class Jukebox<T> 
    {        
        public void Play(T media)
        {
            media.Info();

            
        }

        public T MediaPlaying()
        {
            new T();
        }
    }
}
