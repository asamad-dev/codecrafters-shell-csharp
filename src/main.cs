using System.Net;
using System.Net.Sockets;
// You can use print statements as follows for debugging, they'll be visible when running tests.
// Console.WriteLine("Logs from your program will appear here!");
string[] builtins = { "exit", "echo", "type" };
while (true)
{
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

            if (cmd == null)
            {
                Console.WriteLine($"{command}: not found");
                break;
            }
            if (builtins.Contains(cmd))
            {
                Console.WriteLine($"{cmd} is a shell builtin");
            }
            else
            {
                string? executablePath = FindExecutableInPath(cmd);
                if (!string.IsNullOrEmpty(executablePath))
                {
                    Console.WriteLine($"{cmd} is {executablePath}");
                }
                else
                {
                    Console.WriteLine($"{cmd}: not found");
                }
            }
            break;
        default:
            Console.WriteLine($"{command}: not found");
            break;

    }
}

string? FindExecutableInPath(string fileName)
{
    string? pathEnv = Environment.GetEnvironmentVariable("PATH");
    if (string.IsNullOrEmpty(pathEnv))
    {
        return null;
    }

    string[] paths = pathEnv.Split(Path.PathSeparator);

    // Add common executable extensions for Windows
    string[] extensions = Environment.OSVersion.Platform == PlatformID.Win32NT
        ? new[] { ".exe", ".bat", ".cmd" }
        : new[] { "" }; // No extensions for Unix-like systems

    foreach (var path in paths)
    {
        foreach (var ext in extensions)
        {
            string fullPath = Path.Combine(path, fileName + ext);
            if (File.Exists(fullPath))
            {
                return fullPath;
            }
        }
    }

    return null; // Not found
}