using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lesson__18__ServerUDP_
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 8081;

            // точка подключения 
            var udpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            // создадим наш сокет который ожидает приема сообщений
            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            udpSocket.Bind(udpEndPoint);

            while (true)
            {
                var buffer = new byte[256];
                var size = 0;
                var data = new StringBuilder();

                //EndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, 0);
                EndPoint senderEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

                do
                {
                    //size = udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                    size = udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer));
                }
                while
                (udpSocket.Available > 0);

                udpSocket.SendTo(Encoding.UTF8.GetBytes("Сообщение получено!"), senderEndPoint);

                //udpSocket.Shutdown(SocketShutdown.Both);
                //udpSocket.Close();

                Console.WriteLine(data);
            }            

            //TODO: закрытие сокета            
        }
    }
}
