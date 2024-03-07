//                  ::SERVER::
using System.Net.Sockets;
using System.Text;
using System.Net;

namespace Server{
    class Program{
        static void Main (string[] args){
            System.Console.WriteLine("Hello, Server!");
            OurServer server = new OurServer();

        }
    }
}
