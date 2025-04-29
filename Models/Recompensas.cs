using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using TorresJ_EvaluacionP1.Models;

namespace TorresJ_EvaluacionP1.Models
{
    public class Recompensas
    {
        //Plan de recompensas(cliente) :
        //  Debe tener 5 atributos: Id, Nombre, Fecha de inicio, puntos acumulados.
        //  (Por cada reserva realizada, el cliente gana 100 puntos) y
        //  tipo de recompensa(menos de 500 puntos: SILVER, más de 500 puntos: GOLD).

        [Key]
        public int IdRecompensas { get; set;}
        [MaxLength(100)]
        [Required]
        [DisplayName("Ingrese el nombre: ")]
        public string Nombre { get; set;}
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set;}
        public int PuntosAcumulados { get; set; }
        public string TipoRecompensa
        {
            get
            {
                return PuntosAcumulados < 500 ? "SILVER" : "GOLD";
            }
        }
    }
}
