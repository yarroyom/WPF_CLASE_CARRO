using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_PrimeraApp.Class
{
    public class carro
    {
        public string Marca { get; }
        public int Modelo { get; }
        public String Color { get; set; }
        public int VMaxima { get; }

        private int Encendido = 0;
        private int velocidad_actual = 0;
        private const int MAXVELOCIDAD = 150;


        public carro(string _marca, int _modelo, string _color, int _vmaxima)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            VMaxima = _vmaxima;
            Encendido = 0;
            this.velocidad_actual = 0;
        }

        public carro(string v1, int v2, string v3)
        {
        }

        public string GetVelocidadActual()
        {
            return $"vamos a {velocidad_actual} KM/H";
        }

        public string EncendidoMotor()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                return ("Tu carro esta listo para correr");
                
                velocidad_actual = 0;
            }
            else
            {
               return ("Ya esta encendido tu carro!!!");
            }
        }

        public string acelerar()
        {
           
            if (Encendido ==0 )
            {
                return$"no puedes acelerar, tu auto esta apagado";
                
            }


            string mensaje = "";
                if (velocidad_actual <= VMaxima)
                { 
                    velocidad_actual+=20;
                    mensaje = $"Vas a {velocidad_actual} KPH";
                }
                else
                {
                    velocidad_actual = VMaxima;
                    mensaje = $"{velocidad_actual}KPH Aguas rapido y furioso, vas muy rapido y ya llegaste al tope";
                }


                Console.WriteLine(mensaje);
                return mensaje;
            
        }


        public string desacelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"No puedes desacelerar si el carro esta apagado!!";
                return mensaje;
            }
            else
            {
                velocidad_actual -= 5;
                mensaje = $"Vas desacelerando, tu velocidad actual es {velocidad_actual}";

            }
            Console.WriteLine(mensaje);
            return mensaje;

        }

        public string frenar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = "El carro esta apagado, no podemos frenar";
            }
            else
            {
                velocidad_actual -= 10;
                if (velocidad_actual >= 0)
                {
                    mensaje = $" vamos frenando, tu velocidad es {velocidad_actual}KM/H";

                }
                else
                {
                    mensaje = $"Ya no puedes frenar, vamos a 0KM/H";
                }
            }


            Console.WriteLine(mensaje);
            return mensaje;
        }

        public string apagarmotor()
        {
            if (Encendido == 1)
            {
                Encendido = 0;
                return "El Carro esta siendo apagado";
                return"El carro ya está apagado";
            }
            else
            {
                return"Lo siento! tu carro ya estaba apagado";
            }
        }

        public string Bocinar()
        {
            string mensaje = "wiii wiii wiiiiii!!! tu carro esta bocinando!";
            Console.WriteLine(mensaje);
            return mensaje;
        }
    }
}
    

