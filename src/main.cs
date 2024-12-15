using System.Net;
using System.Net.Sockets;
// You can use print statements as follows for debugging, they'll be visible when running tests.
// Console.WriteLine("Logs from your program will appear here!");
while (true) {
    Console.Write("$ ");
    var command = Console.ReadLine();

    if (command.StartsWith("exit")) {

    var cmdArgs = command.Split(' ');

    Environment.Exit(int.Parse(cmdArgs[1]));
  }

  if (command.StartsWith("echo")) {

    var cmdArgs = command.Split(' ');
    if (cmdArgs.Length > 1)
    {
        string remainingArgs = string.Join(" ", cmdArgs.Skip(1));
        Console.WriteLine("remainingArgs = {}", remainingArgs);
        Environment.echo(remainingArgs);
    }
  }
  else
    Console.WriteLine($"{command}: command not found");

}