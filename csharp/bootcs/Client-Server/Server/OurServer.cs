using System.Net.Sockets;
using System.Text;
using System.Net;

namespace Server{
    class OurServer{
        private TcpListener server; // слушаем подключения

        public OurServer(){
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 5555); // создаем сервер, слушаем адрес/порт
            server.Start(); // запускаем...

            LoopClients();
        }

        // ловим клиентов
        void LoopClients (){
            while(true){
                TcpClient client = server.AcceptTcpClient(); // как только есть подкл к серверу, создается клиент, кот. будем обрабатывать на сервере

            // обрабатываем в отдельных потоках
            Thread thread = new Thread (() => HandleClient(client));
            thread.Start();
            }
        }

        // держим соединение с отдельным клиентом
        void HandleClient(TcpClient client){
            //StreamReader sReader = new StreamReader(client.GetStream(), Encoding.UTF8); // получаем поток
            //StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);

            //while (true){
                

               
            //}
            Thread _read = new Thread (() => ReadMessage(client));
            _read.Start();
            Thread _write = new Thread (() => WriteMessage(client));
            _write.Start();
        }

        void ReadMessage (TcpClient client){
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.UTF8);

            while(true){
                string message = sReader.ReadLine(); //получаем строку из потока
                System.Console.WriteLine($"Client writes: {message}");
            }
        }

        void WriteMessage(TcpClient client){
            StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);
            while (true){
                System.Console.Write("> ");
                string? text = Console.ReadLine();
                sWriter.WriteLine(text); // отправляем сообщение на сервер...
                sWriter.Flush(); // ...немедленно!
            }
        }
    }
}