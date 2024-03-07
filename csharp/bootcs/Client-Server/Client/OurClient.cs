using System.Net.Sockets;
using System.Text;

namespace Client{
    class OurClient{
        private TcpClient client; //работа с тсп
        private StreamWriter sWriter; // записывать данные на сервер
        private StreamReader sReader;

        public OurClient(){
            client = new TcpClient ("127.0.0.1", 5555); // даем клиенту айпи и порт, куда подключаться
            sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8); // вытаскиваем поток, по кот. будет взаимодействие
            sReader = new StreamReader(client.GetStream(), Encoding.UTF8);

            HandleCommunication();
        }

        // держим подключение
        void HandleCommunication(){
            while(true){
                System.Console.Write("> ");
                string? message = Console.ReadLine();
                sWriter.WriteLine(message); // отправляем сообщение на сервер...
                sWriter.Flush(); // ...немедленно!

                string text = sReader.ReadLine(); //получаем строку из потока
                System.Console.WriteLine($"Server writes: {text}");
            }
        }
    }
}