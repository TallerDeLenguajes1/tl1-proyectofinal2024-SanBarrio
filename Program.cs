﻿//Alumno: Barrionuevo Santiago Horacio - Ing. En Informática
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Net.Http;


using Visuales;
using Start;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;
       
        Mostrar.WriteAt("█████  █   █  █████     ████   ██  ██  █   █  █████  █████  █████  █   █", 10,2, ConsoleColor.White);
        Mostrar.WriteAt("█    █   █  █         █   █  ██  ██  ██  █  █      █      █   █  ██  █", 12,3, ConsoleColor.White);
        Mostrar.WriteAt("█    █████  ████      █   █  ██  ██  █████  █ ███  ████   █   █  █████", 12,4, ConsoleColor.White);
        Mostrar.WriteAt("█    █   █  █         █   █  ██  ██  █  ██  █  ██  █      █   █  █  ██", 12,5, ConsoleColor.White);
        Mostrar.WriteAt("█    █   █  █████     ████    ████   █   █  █████  █████  █████  █   █", 12,6, ConsoleColor.White);

        bool salir = false;


        while (!salir)
        {
            Mostrar.WriteAt("1.Jugar", 33, 9, ConsoleColor.White);
            Mostrar.WriteAt("2.Salir", 33, 11, ConsoleColor.White);
            Mostrar.WriteAt("Numero: ", 33, 14, ConsoleColor.Red);

            int i;
            int.TryParse(Console.ReadLine(), out i);
            switch (i)
            {
                case 1:
                     
                    break;
                case 2:
                    salir = true;
                    break;
            }
        }

    }
    
}