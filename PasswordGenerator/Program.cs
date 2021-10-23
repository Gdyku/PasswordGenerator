using System;
using PasswordGenLib;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomPasswordFunctions password = new RandomPasswordFunctions();
            //Długość hasła:int 
            //Symbols(!@#): bool
            //numbers: bool
            //lowercase characters bool
            //uppercase characters bool
            //po każdym buildzie aplikacja ma zwiekszać swoją wersje
            //zrobić plik exe

            Console.WriteLine("Hello! How long your password should be? Please provide a length in numbers");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(password.ReturnRandomString(size));           

            Console.ReadKey();
        }
    }
}
