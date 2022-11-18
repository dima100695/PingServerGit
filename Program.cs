using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PingServer
{
    internal class Program
    {

        static string hostName; //ip adres or dns name host
        static bool pingStatus = false; //статус ринга (есле ответ от хоста получен то true) 

        static void Getping ()
        {
            pingStatus = false;
            try
            {
                Ping ping = new Ping();
                PingReply status = ping.Send(hostName, 5000);   // отправка запроса на доступность
                pingStatus =( status.Status == IPStatus.Success) ;

            }
            catch
            {
                Console.WriteLine("проблеммы с сетью!!!");
            }

        }



        static void Main(string[] args)
        {



        }
    }
}
