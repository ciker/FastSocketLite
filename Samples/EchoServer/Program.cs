using FastSocketLite.Server;
using FastSocketLite.SocketBase;
using System;

namespace EchoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SocketServerManager.Init();
                SocketServerManager.Start();

                //每隔10秒强制断开所有连接
                System.Threading.Tasks.Task.Factory.StartNew(() =>
                {
                    while (true)
                    {
                        System.Threading.Thread.Sleep(1000 * 10);
                        IHost host;
                        if (SocketServerManager.TryGetHost("quickStart", out host))
                        {
                            var arr = host.ListAllConnection();
                            foreach (var c in arr) c.BeginDisconnect();
                        }
                    }
                });
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"[Exception: {ex.ToString()}");
            }
        }
    }
}
