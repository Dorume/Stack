using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static string command;
        static int argument = 0;
        static NodeStack stack = new NodeStack();
        static void Main()
        {
            Dictionary<string, Action> commands = new Dictionary<string, Action>()
            {
                {"push", () => Push()},
                {"pop", () => Pop()},
                {"back", () => Back()},
                {"exit", () => Exit()},
                {"clear", () => Clear()},
                {"size", () => Size()}
            };
            while (true)
            {
                command = Console.ReadLine();
                SplitCommandAndArgument();
                if (commands.ContainsKey(command))
                    commands[command]();
                else
                    PrintError();
            }
        }

        private static void Clear()
        {
            stack.Clear();
            PrintOk();
        }

        private static void Back()
        {
            if (stack.Size != 0)
                Console.WriteLine(stack.Back());
            else
                PrintError();
        }

        static void SplitCommandAndArgument()
        {
            string[] data = command.Split(new char[] { ' ' });
            command = data[0];
            if(command == "push")
            {
                argument = 0;
                int.TryParse(data[1], out argument);
            }
        }
        static void Size() => Console.WriteLine(stack.Size);
        static void Exit()
        {
            Console.WriteLine("bye");
            Console.ReadKey();
            Environment.Exit(0);
        }
        static void Push()
        {
            stack.Push(argument);
            PrintOk();
        }
        static void Pop()
        {
            if (stack.Size != 0)
            {
                Console.WriteLine(stack.Pop());
            }
            else PrintError();

        }

        static void PrintError() => Console.WriteLine("error :(");
        static void PrintOk() => Console.WriteLine("Ok :)");
    }
}
