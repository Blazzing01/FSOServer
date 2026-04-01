using FSOServer;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        var gameServer = new GameServer();

        while (true)
        {
            string input = Console.ReadLine() ?? "";

            if (input.ToLower() == "exit" || input.ToLower() == "quit")
            {
                break;
            }
        }
    }
}
