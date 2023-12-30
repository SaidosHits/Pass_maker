using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string current_directory = AppDomain.CurrentDomain.BaseDirectory;
        string file_name = "input.txt";
        string search = Path.Combine(current_directory, file_name);
        Banner();
        if(File.ReadAllText(file_name) == "")
        {
            Console.WriteLine("Sorry the input file is Empty :) ");
            Console.ReadLine();
            return;
        }
        if (File.Exists(search))
        {
            Console.WriteLine("Press any key to start....");
            Console.ReadKey();
            Process(file_name);
        }
        else
        {
           Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine($"Sorry, the {file_name} is not found !");
            Console.ReadKey();
        }

    }

    static void Banner()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                                                                            ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("  ██╗░░██╗██╗░░░██╗███╗░░██╗███╗░░██╗██╗░░░██╗██████╗░░█████╗░░██████╗░██████╗");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("  ██╗░░██╗██╗░░░██╗███╗░░██╗███╗░░██╗██╗░░░██╗██████╗░░█████╗░░██████╗░██████╗");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  ██║░░██║██║░░░██║████╗░██║████╗░██║╚██╗░██╔╝██╔══██╗██╔══██╗██╔════╝██╔════╝");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("  ███████║██║░░░██║██╔██╗██║██╔██╗██║░╚████╔╝░██████╔╝███████║╚█████╗░╚█████╗░");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("  ██╔══██║██║░░░██║██║╚████║██║╚████║░░╚██╔╝░░██╔═══╝░██╔══██║░╚═══██╗░╚═══██╗");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("  ██║░░██║╚██████╔╝██║░╚███║██║░╚███║░░░██║░░░██║░░░░░██║░░██║██████╔╝██████╔╝");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("  ╚═╝░░╚═╝░╚═════╝░╚═╝░░╚══╝╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░░░░╚═╝░░╚═╝╚═════╝░╚═════╝░");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("                                                                            ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Telegram ==========> @SaidosHits");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");
    }

    static void Process(string file_name)
    {
        List<string> secondPartsList = new List<string>();

        using (StreamReader reader = File.OpenText(file_name))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Split each line into an array using ':' as the delimiter
                string[] parts = line.Split(':');
                if (parts.Length > 1 && parts.Length <= 15)
                {
                    // parts[1] contains the second part after the ':'
                    secondPartsList.Add(parts[1]);
                }
            }
        }

        // Save the secondPartsList to a text file
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        File.WriteAllLines("output.txt", secondPartsList);

        Console.WriteLine("All Password  have been saved to 'output.txt'");
        Console.ReadKey();
    }
}
