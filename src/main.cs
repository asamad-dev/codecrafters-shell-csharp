using System.Net;
using System.Net.Sockets;
// You can use print statements as follows for debugging, they'll be visible when running tests.
// Console.WriteLine("Logs from your program will appear here!");
while (true) {
    Console.Write("$ ");
    var command = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(command))
    {
        continue; // Skip empty input
    }
    var cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    var mainCommand = cmdArgs[0];

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
            string? cmd = cmdArgs.Length > 1 ? cmdArgs[1] : null;

            if (cmd == null) {
                break;
            }
            switch (cmd)
            {
                case "exit":
                case "echo":
                case "type":
                    Console.WriteLine($"{cmd} is a shell builtin");
                    break;
                default:
                    Console.WriteLine($"{cmd}: not found");
                    break;
            }
            break;
        default:
            Console.WriteLine($"{command}: not found");
            break;

    }
}