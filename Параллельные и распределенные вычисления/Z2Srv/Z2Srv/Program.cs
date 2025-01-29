using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

class Z2Srv
{
    private static List<TcpClient> clients = new List<TcpClient>();

    public static async Task HandleClientAsync(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[256];
        int bytesRead;

        while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
        {
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Получено: " + message);

            foreach (var c in clients)
            {
                if (c != client)
                {
                    NetworkStream clientStream = c.GetStream();
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    await clientStream.WriteAsync(data, 0, data.Length);
                }
            }

            Array.Clear(buffer, 0, buffer.Length);
        }

        clients.Remove(client);
        client.Close();
    }

    public static async Task StartServerAsync(int port)
    {
        TcpListener listener = new TcpListener(IPAddress.Any, port);
        listener.Start();
        Console.WriteLine("Сервер запущен!");

        while (true)
        {
            TcpClient client = await listener.AcceptTcpClientAsync();
            clients.Add(client);
            Console.WriteLine("Подключен новый клиент");

            _ = HandleClientAsync(client);
        }
    }

    static async Task Main(string[] args)
    {
        await StartServerAsync(7000);
    }
}