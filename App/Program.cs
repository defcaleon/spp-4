using System;
using Business;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var generatingOptions = new GeneratingOptions();
            Console.WriteLine("Enter source path");
            generatingOptions.SourceDirectory = @"D:\study\myspp\4\SrcFiles\Files";//Console.ReadLine();
            Console.WriteLine("Enter destination path");
            generatingOptions.DestinationDirectory = @"D:\study\myspp\4\Tests";//Console.ReadLine();
            Generator.GenerateAsync(generatingOptions).Wait();
        
        }
    }
}