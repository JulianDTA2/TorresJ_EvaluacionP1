using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TorresJ_EvaluacionP1.Models;

namespace TorresJ_EvaluacionP1.Models
{
    public class Reserva
    {
        //Reserva: Se debe incluir la fecha de la reserva (entrada y salida), valor a pagar e información del cliente.

        [Key]
        public int IdReserva { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaEntrada { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }
        [Range(0, 9999)]
        public decimal ValorPago { get; set; }
        public int InfoIdCliente { get; set; }
        [ForeignKey("InfoIdCliente")]
        public Cliente? Cliente { get; set; }

    }
}
