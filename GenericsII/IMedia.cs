using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsII
{
    public interface IMedia
    {
        byte[] Data { get; set; }

        void Info();

        IMedia Media { get; set; }
    }
}
