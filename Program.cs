using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplainInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IStorageService storageService = null;
            //if(us)
            {
                storageService = new StorageOnlineService();
            }
            else
            {
                storageService = new FileSystemStorageService();
            }
            
            DownloadInSystem(new MegaDownload(storageService));
            DownloadInSystem(new TorrentDownload(storageService));
        }

        static void DownloadInSystem(MegaDownload download)
        {
            download.Save();
        }

        
    }
}
