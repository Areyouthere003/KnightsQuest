﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class menu
    {
        static bool Detector()
        {
            ConsoleKeyInfo teclas = new ConsoleKeyInfo();
            bool valor;
            char caracter;
            teclas = Console.ReadKey();
            caracter = teclas.KeyChar;
            if (char.IsWhiteSpace(caracter))
            {
                valor = true;
            }
            else
                valor = false;

            return valor;
        }
        public static void Menucito()
        {
            int tiempoEspera = 10;
            while (tiempoEspera > 1)
            {
                Console.WriteLine("         ******************************");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ████████╗██╗░░██╗███████╗░░░██╗░░██╗███╗░░██╗██╗░██████╗░██╗░░██╗████████╗██╗░██████╗░");
                Console.WriteLine("         ╚══██╔══╝██║░░██║██╔════╝░░░██║░██╔╝████╗░██║██║██╔════╝░██║░░██║╚══██╔══╝╚█║██╔════╝░");
                Console.WriteLine("         ░░░██║░░░███████║█████╗░░░░░█████═╝░██╔██╗██║██║██║░░██╗░███████║░░░██║░░░░╚╝╚█████╗░░");
                Console.WriteLine("         ░░░██║░░░██╔══██║██╔══╝░░░░░██╔═██╗░██║╚████║██║██║░░╚██╗██╔══██║░░░██║░░░░░░░╚═══██╗░");
                Console.WriteLine("         ░░░██║░░░██║░░██║███████╗░░░██║░╚██╗██║░╚███║██║╚██████╔╝██║░░██║░░░██║░░░░░░██████╔╝░");
                Console.WriteLine("         ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░░░░╚═════╝░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░██████╗░██╗░░░██╗███████╗░██████╗████████╗░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░██╔═══██╗██║░░░██║██╔════╝██╔════╝╚══██╔══╝░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░██║██╗██║██║░░░██║█████╗░░╚█████╗░░░░██║░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░╚██████╔╝██║░░░██║██╔══╝░░░╚═══██╗░░░██║░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░░╚═██╔═╝░╚██████╔╝███████╗██████╔╝░░░██║░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░╚═╝░░░░╚═════╝░╚══════╝╚═════╝░░░░╚═╝░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ******************************");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                int modulo = tiempoEspera % 2;
                if (modulo == 0)
                {
                    Console.WriteLine("");
                    tiempoEspera--;
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("                              PRESIONE ESPACIO PARA COMENZAR");
                    tiempoEspera--;
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            if (tiempoEspera < 2)
            {
                Console.WriteLine("         ******************************");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ████████╗██╗░░██╗███████╗░░░██╗░░██╗███╗░░██╗██╗░██████╗░██╗░░██╗████████╗██╗░██████╗░");
                Console.WriteLine("         ╚══██╔══╝██║░░██║██╔════╝░░░██║░██╔╝████╗░██║██║██╔════╝░██║░░██║╚══██╔══╝╚█║██╔════╝░");
                Console.WriteLine("         ░░░██║░░░███████║█████╗░░░░░█████═╝░██╔██╗██║██║██║░░██╗░███████║░░░██║░░░░╚╝╚█████╗░░");
                Console.WriteLine("         ░░░██║░░░██╔══██║██╔══╝░░░░░██╔═██╗░██║╚████║██║██║░░╚██╗██╔══██║░░░██║░░░░░░░╚═══██╗░");
                Console.WriteLine("         ░░░██║░░░██║░░██║███████╗░░░██║░╚██╗██║░╚███║██║╚██████╔╝██║░░██║░░░██║░░░░░░██████╔╝░");
                Console.WriteLine("         ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░░░░╚═════╝░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░██████╗░██╗░░░██╗███████╗░██████╗████████╗░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░██╔═══██╗██║░░░██║██╔════╝██╔════╝╚══██╔══╝░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░██║██╗██║██║░░░██║█████╗░░╚█████╗░░░░██║░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░╚██████╔╝██║░░░██║██╔══╝░░░╚═══██╗░░░██║░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░░╚═██╔═╝░╚██████╔╝███████╗██████╔╝░░░██║░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░╚═╝░░░░╚═════╝░╚══════╝╚═════╝░░░░╚═╝░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("         ******************************");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");


                Console.WriteLine("                              PRESIONE ESPACIO PARA COMENZAR");
                if (Detector() == true)
                {
                    Console.Clear();
                    Loading.Carga();
                    Console.Clear();
                    Logica.Logica1();   //aqui vamos directo a la logica del juego se cambia 
                                        //las variable de estas lineas por la llamada al juego
                }
                else
                {
                    Console.Clear();
                    Menucito();
                }
            }
        }
    }
}