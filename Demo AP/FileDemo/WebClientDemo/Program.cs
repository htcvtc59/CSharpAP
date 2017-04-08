using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            download();
        }
        static void download(){
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += onDownload;
            webClient.DownloadFileAsync(new Uri("http://download1641.mediafire.com/huic6fp5c4pg/8h2as59grpo2aqh/AssignmentMVC4.rar"), "C:\\demo\\asm.rar");
            Console.ReadKey();
            
        }

        private static void onDownload(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Recieved: {0} %", e.ProgressPercentage);
            
        }
        
      
    }
}
