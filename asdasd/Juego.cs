using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Otracosa
{
    public class Juego
    {
        Task tarea;
        private int ronda;
        private string ganador;

        public event Action<string> MandarMensaje;
        public event EventHandler TerminoPartida;

        public Juego()
        {
            ronda = 1;
            tarea = new Task(Jugar);
        }

        public string Ganador
        {
            get
            {
                return this.ganador;
            }
        }

        public void ComenzarPartida()
        {
            tarea.Start();
        }

        private void Jugar()
        {
            while (true)
            {
                Thread.Sleep(500);
                if(MandarMensaje is not null)
                {
                    MandarMensaje($"Se esta jugando la ronda {ronda}\n");
                }
                if(ronda == 3)
                {
                    ganador = "El que gano";
                    break;
                }
                ronda++;
            }
            if(TerminoPartida is not null)
            {
                TerminoPartida(this, EventArgs.Empty);
            }
        }
    }
}
