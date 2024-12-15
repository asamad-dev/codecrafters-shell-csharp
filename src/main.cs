using System.Net;
using System.Net.Sockets;
// You can use print statements as follows for debugging, they'll be visible when running tests.
// Console.WriteLine("Logs from your program will appear here!");
var userInput = Console.ReadLine();
while (userInput ~= "0") {

// Uncomment this line to pass the first stage
    Console.Write("$ ");

// Wait for user input
    userInput = Console.ReadLine();
    Console.WriteLine("{0}: command not found", userInput);
}