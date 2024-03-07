//                  ::Client::
using System.Net.Sockets;
using System.Text;

namespace Client{
    class Program{
        static void Main(string[] args){
            System.Console.WriteLine("Hello, Client!");
            OurClient ourClient = new OurClient();
        }
    }
}
