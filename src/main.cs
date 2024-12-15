using System.Net;
using System.Net.Sockets;
// You can use print statements as follows for debugging, they'll be visible when running tests.
// Console.WriteLine("Logs from your program will appear here!");
while (true) {
    Console.Write("$ ");
    var command = Console.ReadLine();
    var cmdArgs = command.Split(' ');
    var mainCommand = cmdArgs[0]; // Extract the main command (first word)

    switch (mainCommand)
    {
        case "exit":
            Environment.Exit(int.Parse(cmdArgs[1]));
            break;
        case "echo":    
            string remainingArgs = string.Join(" ", cmdArgs.Skip(1));
            Console.WriteLine(remainingArgs);
            break;
        case "type":   
            string secondArgs = cmdArgs[1];
            switch (secondArgs)
            {
                case "exit":
                case "echo":
                case "type":
                    Console.WriteLine($"{secondArgs} is a shell builtin\n'");
                    break;
            }
            break;
        default:
            Console.WriteLine($"{command}: command not found\n'");
            break;

    }
}