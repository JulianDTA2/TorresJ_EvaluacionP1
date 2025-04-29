using System.Numerics;

namespace TorresJ_EvaluacionP1.Models
{
    public class Recompensas
    {
        //Plan de recompensas(cliente) :
        //  Debe tener 5 atributos: Id, Nombre, Fecha de inicio, puntos acumulados.
        //  (Por cada reserva realizada, el cliente gana 100 puntos) y
        //  tipo de recompensa(menos de 500 puntos: SILVER, más de 500 puntos: GOLD).

        public int IdRecompensas { get; set;}
        public string Nombre { get; set;}
        public DateTime? FechaInicio { get; set;}
        public decimal PuntosAc 
        {
            get
            {

                return 0;
            }
        }
    }
}
