﻿using System;
using System.IO;
using static System.Console;
namespace Ex1StreamRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                FileStream aFile = new FileStream("Log.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                line = sr.ReadLine();
                // Read data in line by line.
                while (line != null)
                {
                    WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }

                catch (IOException e)
            {
                WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                //return;
            }
            Console.ReadKey();
        }
    }
}
