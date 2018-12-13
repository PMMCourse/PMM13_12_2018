using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplainInterfaces
{
    class MegaDownload : IDownloadble
    {
        public MegaDownload(IStorageService storageService) : base(storageService)
        {
        }

        public void Download()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        private override void Download()
        {
            throw new NotImplementedException();
        }
    }
}
