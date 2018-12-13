using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsII
{
    class Video : IMedia
    {
        public byte[] Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Info()
        {
            throw new NotImplementedException();
        }
    }
}
