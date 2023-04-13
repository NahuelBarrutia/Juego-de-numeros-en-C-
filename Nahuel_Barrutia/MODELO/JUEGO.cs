using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{

    public class JUEGO
    {
        private static JUEGO instancia;
        public static JUEGO OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new JUEGO();

            return instancia;
        }

        private JUEGO()
        {
            PARTIDAS = new List<PARTIDA>();
        }
        public List<PARTIDA> PARTIDAS { get; set; } //Lista de todas las partidas del programa

        public List<PARTIDA> OBTENER_PARTIDAS(string filtro) //Creo lista de partidas segun el filtro de ganadas o perdidas //  paso por parametro un filtro en este caso es lo que esta escrito en mi combobox
        {
            var partidas = from partida in PARTIDAS // creo una variable partidas, y le digo que busque en mi lista de PARTIDAS 
                          where (filtro != null ? partida.RESULTADO == filtro : true) // donde lo que diga mi filtro pregunto si existe algo
                          select partida;// si existe algo lo selecciona 
            return partidas.ToList();// entonces lista todo lo que encuentre que coincida con mi filtro
        }
    }
}

