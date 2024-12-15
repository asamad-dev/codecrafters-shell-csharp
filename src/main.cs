using System.Net;
using System.Net.Sockets;
// You can use print statements as follows for debugging, they'll be visible when running tests.
// Console.WriteLine("Logs from your program will appear here!");
string userInput = ""
while (userInput ~= "exit 0") {

// Uncomment this line to pass the first stage
    Console.Write("$ ");

// Wait for user input
    userInput = Console.ReadLine() as String;
    Console.WriteLine("{0}: command not found", userInput);
}