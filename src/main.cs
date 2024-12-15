using System.Net;
using System.Net.Sockets;
// You can use print statements as follows for debugging, they'll be visible when running tests.
// Console.WriteLine("Logs from your program will appear here!");
while (true) {

// Uncomment this line to pass the first stage
    Console.Write("$ ");

// Wait for user input
    var userInput = Console.ReadLine();
    Console.WriteLine("{0}: command not found", userInput);
}