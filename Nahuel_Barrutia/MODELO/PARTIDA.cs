using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public abstract class PARTIDA
    {
        //Creo la instacia del generador de numeros aleatorios
        private readonly Random _random = new Random();

        public int INTENTO { get; set; }
        public int CREDITO { get; set; } = 100; //Cargo los 100 creditos por default
        public string RESULTADO { get; set; }

        public int numero;

        
        public PARTIDA()
        {
            numero = _random.Next(0, 10); //Genero el numero aleatorio entre 0 y 100 para la partida 
        }


        public abstract void verificarNro(int nro);

    }

    public class PARTIDANORMAL : PARTIDA //hereda de PARTIDA
    {
        public override void verificarNro(int nro) //Cambio la implementacion de VerificarNro (Polimorfismo)
        {
            if (nro == numero)
            {
                INTENTO = INTENTO + 1;
                RESULTADO = "Ganada";
            }
            else
            {
                INTENTO = INTENTO + 1;
                CREDITO = CREDITO - 5;
                RESULTADO = "No Acertado";
                if (CREDITO == 0)
                {
                    RESULTADO = "Perdida";
                    throw new Exception("sin creditos. Partida finalizada.");
                }
            }
        }

    }
    public class PARTIDACONAYUDA : PARTIDA //hereda de PARTIDA
    {
        public override void verificarNro(int nro) //Cambio la implementacion de VerificarNro, (Polimorfismo)
        {

            if (nro == numero)
            {
                INTENTO = INTENTO + 1;
                RESULTADO = "Ganada";
            }
            else
            {
                INTENTO = INTENTO + 1;
                CREDITO = CREDITO - 10;
                RESULTADO = "No Acertado";

                if (CREDITO == 0)
                {
                    RESULTADO = "Perdida";
                    throw new Exception("Sin creditos. Partida finalizada.");
                }
                else
                {
                    if ((nro > numero - 5) && (nro < numero + 5))
                    {
                        throw new Exception("Estuvo cerca");
                    }
                    else
                    {
                        throw new Exception("El numero está lejos del elegido");
                    }
                }
            }
        }
    }
}
