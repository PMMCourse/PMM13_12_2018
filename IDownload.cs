using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplainInterfaces
{
    public abstract class IDownloadble
    {
        protected StorageOnlineService storageService;

        public IDownloadble(IStorageService storageService)
        {
            this.storageService = storageService;
        }

        abstract void Download();

        public void Save()
        {
            storageService.Store();
        }

        long Size { get; set; }
    }
}
