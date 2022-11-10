using System;
using Otracosa;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            juego.MandarMensaje += MostrarUnMensaje;
            juego.TerminoPartida += ImprimirDatosDeLaPartida;
            Console.ReadKey();
            juego.ComenzarPartida();

            Console.ReadKey();

        }

        static void MostrarUnMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        static void ImprimirDatosDeLaPartida(object sender, EventArgs e)
        {
            Juego juego = (Juego)sender;
            Console.WriteLine(juego.Ganador);
        }
    }
}
